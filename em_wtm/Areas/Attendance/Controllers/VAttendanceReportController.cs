using BootstrapBlazor.Components;
using em_wtm.BLL;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.VAttendanceReportVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.Mvc;

namespace em_wtm.Controllers
{
    [Area("Attendance")]
    [AuthorizeJwt]
    [ActionDescription("考勤报表")]
    [ApiController]
    [Route("api/VAttendanceReport")]
    public partial class VAttendanceReportController : BaseApiController
    {
        [ActionDescription("Sys.Search")]
        [HttpPost("Search")]
        public IActionResult Search(VAttendanceReportSearcher searcher)
        {
            if (ModelState.IsValid)
            {
                var vm = Wtm.CreateVM<VAttendanceReportListVM>();
                vm.Searcher = searcher;

                bool hasAM = isAttendanceManageRole(searcher.LoginUserInfo);
                if (!hasAM)
                {
                    Attendance2EmployeeRefSchemeClass emp = GetAttendanceEmployee().First();
                    if (emp != null)
                    {
                        int empId = emp.EmployeeId;
                        vm.Searcher.EmployeeId = empId;
                    }
                    else throw new UnauthorizedAccessException("用户未与考勤员工关联");
                }
                var returnContent = vm.GetJson(enumToString: false);
                return Content(returnContent);
            }
            else
            {
                return BadRequest(ModelState.GetErrorJson());
            }
        }
        [ActionDescription("Attendance.GetEmployeeInfo")]
        [HttpGet("GetAttendanceEmployee")]
        public List<Attendance2EmployeeRefSchemeClass> GetAttendanceEmployee()
        {
            var EmployeeRefSchemeClassQuery = DC.Set<Attendance2EmployeeRefSchemeClass>()
                .Where(w => w.UserId == new Guid(Wtm.LoginUserInfo.UserId)
                && w.ExpDate == null)
                .OrderByDescending(w => w.EffDate);
            string currLoginName = Wtm.LoginUserInfo.Name;
            var Employees = EmployeeRefSchemeClassQuery.ToList();
            var emp = Employees.FirstOrDefault(f => f.EmployeeName == currLoginName, null);
            if (emp != null)
            {
                Employees.Remove(emp);
                Employees.Insert(0, emp);
            }
            return Employees;
        }

        [ActionDescription("Attendance.IsAttendanceManageRole")]
        [HttpGet("IsAttendanceManageRole")]
        public bool IsAttendanceManageRole()
        {
            return isAttendanceManageRole(Wtm.LoginUserInfo);
        }
        private bool isAttendanceManageRole(LoginUserInfo loginUserInfo)
        {
            return loginUserInfo.Roles.Exists(f => f.RoleName == "考勤导入" || f.RoleName == "考勤管理" || f.RoleName == "超级管理员");
        }

        [ActionDescription("Attendance.GetRecord")]
        [HttpGet("{id}")]
        public VAttendanceReportVM Get(string id)
        {
            var vm = Wtm.CreateVM<VAttendanceReportVM>(id);
            return vm;
        }
        [ActionDescription("Attendance.GetRecord")]
        [HttpGet("{id}/{isBTimeClick}")]
        public VAttendanceReportVM Get(string id, bool isBTimeClick)
        {
            var vm = Wtm.CreateVM<VAttendanceReportVM>(id);
            vm.Entity.isBTimeClicked = isBTimeClick;
            var emp = DC.Set<VAttendanceEmployee>().Single(s => s.ID == vm.Entity.EmployeeId);
            vm.Entity.Employee = emp;
            return vm;
        }

        [ActionDescription("Sys.Create")]
        [HttpPost("Add")]
        public IActionResult Add(VAttendanceReportVM vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                vm.DoAdd();
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.GetErrorJson());
                }
                else
                {
                    return Ok(vm.Entity);
                }
            }

        }

        [ActionDescription("Sys.Edit")]
        [HttpPut("Edit")]
        public IActionResult Edit(VAttendanceReportVM vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                vm.DoEdit(false);
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.GetErrorJson());
                }
                else
                {
                    return Ok(vm.Entity);
                }
            }
        }

        [HttpPost("BatchDelete")]
        [ActionDescription("Sys.Delete")]
        public IActionResult BatchDelete(string[] ids)
        {
            var vm = Wtm.CreateVM<VAttendanceReportBatchVM>();
            if (ids != null && ids.Count() > 0)
            {
                vm.Ids = ids;
            }
            else
            {
                return Ok();
            }
            if (!ModelState.IsValid || !vm.DoBatchDelete())
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                return Ok(ids.Count());
            }
        }


        [ActionDescription("Sys.Export")]
        [HttpPost("ExportExcel")]
        public IActionResult ExportExcel(VAttendanceReportSearcher searcher)
        {
            var vm = Wtm.CreateVM<VAttendanceReportListVM>();
            vm.Searcher = searcher;
            vm.SearcherMode = ListVMSearchModeEnum.Export;
            return vm.GetExportData();
        }

        [ActionDescription("Sys.CheckExport")]
        [HttpPost("ExportExcelByIds")]
        public IActionResult ExportExcelByIds(string[] ids)
        {
            var vm = Wtm.CreateVM<VAttendanceReportListVM>();
            if (ids != null && ids.Count() > 0)
            {
                vm.Ids = new List<string>(ids);
                vm.SearcherMode = ListVMSearchModeEnum.CheckExport;
            }
            return vm.GetExportData();
        }

        [ActionDescription("Sys.DownloadTemplate")]
        [HttpGet("GetExcelTemplate")]
        public IActionResult GetExcelTemplate()
        {
            var vm = Wtm.CreateVM<VAttendanceReportImportVM>();
            var qs = new Dictionary<string, string>();
            foreach (var item in Request.Query.Keys)
            {
                qs.Add(item, Request.Query[item]);
            }
            vm.SetParms(qs);
            var data = vm.GenerateTemplate(out string fileName);
            return File(data, "application/vnd.ms-excel", fileName);
        }

        [ActionDescription("Sys.Import")]
        [HttpPost("Import")]
        public ActionResult Import(VAttendanceReportImportVM vm)
        {
            if (vm != null && (vm.ErrorListVM.EntityList.Count > 0 || !vm.BatchSaveData()))
            {
                return BadRequest(vm.GetErrorJson());
            }
            else
            {
                return Ok(vm?.EntityList?.Count ?? 0);
            }
        }

        [ActionDescription("Attendance.GetEmployees")]
        [HttpGet("GetVAttendanceEmployees")]
        public ActionResult GetVAttendanceEmployees()
        {
            var empsQuery = EmployeeQueryable();
            return Ok(empsQuery.GetSelectListItems(Wtm, x => x.EmployeeName, x => x.ID));
        }

        [ActionDescription("Attendance.GetEmployees")]
        private IQueryable<VAttendanceEmployee> EmployeeQueryable(int? empid = null)
        {
            var empsQuery = DC.Set<VAttendanceEmployee>().AsQueryable();
            if (empid != null) { empsQuery = empsQuery.Where(w => w.ID == empid); }
            else
            {
                if (Wtm.LoginUserInfo.Roles.Exists(e => e.RoleName == "考勤管理"))
                    return empsQuery;
                //else if (Wtm.LoginUserInfo.Roles.Exists(e => e.RoleName == "考勤导入"))
                empsQuery = empsQuery.Where(w => GetAttendanceEmployee().Select(s => s.EmployeeId).Contains(w.ID));
            }
            return empsQuery;
        }

        [ActionDescription("Sys.ImportAttendance")]
        [HttpPost("ImportFromDingtalk")]
        public async Task<ActionResult> ImportFromDingtalk(VAttendanceReportSearcher searcher)
        {
            int importNum = 0;
            AttendanceBLL dingtalkAttendance = new AttendanceBLL();
            AttendanceSearchModel SearchModel = new AttendanceSearchModel()
            {
                AttendanceEmployees = EmployeeQueryable(searcher.EmployeeId).ToList(),
                DateTimeRange = searcher.SDate
            };
            var dtRecords = await dingtalkAttendance.getDingTalkAttendance(SearchModel);
            if (dtRecords != null)
                importNum = await ImportResult(dtRecords);
            return Ok(importNum);
        }
        [ActionDescription("Sys.ImportAttendance")]
        [HttpPost("ImportFromDevice")]
        public async Task<ActionResult> ImportFromDevice(VAttendanceReportSearcher searcher)
        {
            int importNum;
            importNum = await ImportResult(searcher.SDate.GetStartTime(), searcher.SDate.GetEndTime(), searcher.EmployeeId);

            return Ok(importNum);
        }

        private async Task<int> ImportResult(List<Attendance2Record> records)
        {
            int importNum = 0;

            string spName = "Attendance_SaveAttendanceRecord";
            /* @empId int,@sDate datetime,@cardBegin datetime,@cardEnd datetime */

            foreach (var record in records)
            {
                List<SqlParameter> sqlParameters = new List<SqlParameter>() {
                new SqlParameter("@empId", record.EmployeeId),
                new SqlParameter("@sDate", record.SDate.ToString("yyyy-MM-dd")),
                new SqlParameter("@cardBegin", record.BAttTime),
                new SqlParameter("@cardEnd", record.EAttTime)
                };
                importNum += await DORunSP(spName, sqlParameters.ToArray());
            }

            return importNum;
        }
        private async Task<int> ImportResult(DateTime? start, DateTime? end, int? employeeid = null)
        {
            int importNum = 0;

            string spName = "Attendance_ImportAttendanceDeviceHWATT";
            /*	@empId int,	@beginDate datetime,	@endDate datetime*/
            List<SqlParameter> sqlParameters = new List<SqlParameter>() {
                new SqlParameter("@empId",employeeid??-1),
                new SqlParameter("@beginDate", start?.ToString("yyyy-MM-dd")),
                new SqlParameter("@endDate", end?.ToString("yyyy-MM-dd"))
            };
            if (employeeid.HasValue)
            {
                sqlParameters[0].Value = employeeid.Value;
                importNum = await DORunSP(spName, sqlParameters.ToArray());
            }
            else
            {
                foreach (var emp in EmployeeQueryable().ToArray())
                {
                    sqlParameters = new List<SqlParameter>() {
                        new SqlParameter("@empId",emp.ID),
                        new SqlParameter("@beginDate", start?.ToString("yyyy-MM-dd")),
                        new SqlParameter("@endDate", end?.ToString("yyyy-MM-dd")) };
                    importNum += await DORunSP(spName, sqlParameters.ToArray());
                }
            }

            return importNum;
        }

        [ActionDescription("Attencance.Schedule")]
        [HttpPost("Schedule")]
        public async Task<ActionResult> Schedule(VAttendanceReportSearcher searcher)
        {
            int importNum = 0;
            AttendanceBLL dingtalkAttendance = new AttendanceBLL();
            string spName = "Attendance_schedule";
            /*   @eid INT,@beginDate datetime,@endDate datetime  */
            try
            {
                foreach (var emp in EmployeeQueryable(searcher.EmployeeId).ToArray())
                {
                    List<SqlParameter> sqlParameters = new List<SqlParameter>() {
                        new SqlParameter("@eid", emp.ID),
                        new SqlParameter("@beginDate",  searcher.SDate.GetStartTime().Value),
                        new SqlParameter("@endDate",  searcher.SDate.GetEndTime().Value),
                    };
                    importNum += await DORunSP(spName, sqlParameters.ToArray());
                }
            }
            catch (Exception ex)
            {
            }
            return Ok(importNum);
        }
        private async Task<int> DORunSP(string spName, params object[] spParams)
        {
            int importNum = 0;
            var trans = DC.BeginTransaction();

            try
            {

                using (DataTable dt = DC.RunSP(spName, spParams))
                {
                    /*
                     * var dtreader = dt.CreateDataReader();
                    if (dtreader.Read()) {
                        importNum = int.Parse(dtreader[0].ToString());
                    }
                    else { importNum = 1; }
                    dtreader.Close();
                    */
                    importNum = int.Parse(dt.Rows.Count <= 0 ? "1" : dt.Rows[0][0].ToString());
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }
            finally { trans.Dispose(); }
            return importNum;
        }
        [ActionDescription("Attencance.ReCalc")]
        [HttpPost("ReCalcAttendance")]
        public async Task<ActionResult> ReCalcAttendance(VAttendanceReportSearcher searcher)
        {
            int importNum = 0;
            AttendanceBLL dingtalkAttendance = new AttendanceBLL();
            string spName = "Attendance_reCalculaor";
            /*   @eid INT,@beginDate datetime,@endDate datetime  */
            try
            {
                foreach (var emp in EmployeeQueryable(searcher.EmployeeId).ToArray())
                {
                    List<SqlParameter> sqlParameters = new List<SqlParameter>() {
                        new SqlParameter("@eid", emp.ID),
                        new SqlParameter("@beginDate",  searcher.SDate.GetStartTime().Value),
                        new SqlParameter("@endDate",  searcher.SDate.GetEndTime().Value),
                    };
                    importNum += await DORunSP(spName, sqlParameters.ToArray());
                }
            }
            catch (Exception ex)
            {
            }
            return Ok(importNum);
        }
    }
}