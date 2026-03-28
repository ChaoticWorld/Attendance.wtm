using em_wtm.Model._Business.Attendance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;


namespace em_wtm.ViewModel.Attendance.Attendance2EmployeeRefSchemeClassVMs
{
    public partial class Attendance2EmployeeRefSchemeClassListVM : BasePagedListVM<Attendance2EmployeeRefSchemeClass_View, Attendance2EmployeeRefSchemeClassSearcher>
    {

        protected override IEnumerable<IGridColumn<Attendance2EmployeeRefSchemeClass_View>> InitGridHeader()
        {
            return new List<GridColumn<Attendance2EmployeeRefSchemeClass_View>>{
                this.MakeGridHeader(x => x.ID),
                this.MakeGridHeader(x => x.Name_view),
                this.MakeGridHeader(x => x.EmployeeId),
                this.MakeGridHeader(x => x.ClassName_view),
                this.MakeGridHeader(x => x.EffDate),
                this.MakeGridHeader(x => x.PeriodNo),
                this.MakeGridHeader(x => x.ExpDate),
                this.MakeGridHeader(x => x.EmployeeName),
                this.MakeGridHeaderAction(width: 200)
            };
        }

        public override IOrderedQueryable<Attendance2EmployeeRefSchemeClass_View> GetSearchQuery()
        {
            var query = DC.Set<Attendance2EmployeeRefSchemeClass>()
                .CheckEqual(Searcher.ClassId, x => x.ClassId)
                .CheckContain(Searcher.EmployeeName, x => x.EmployeeName)
                .Select(x => new Attendance2EmployeeRefSchemeClass_View
                {
                    ID = x.ID,
                    Name_view = x.User.Name,
                    EmployeeId = x.EmployeeId,
                    ClassName_view = x.Class.ClassName,
                    EffDate = x.EffDate,
                    PeriodNo = x.PeriodNo,
                    ExpDate = x.ExpDate,
                    EmployeeName = x.EmployeeName,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }

    public class Attendance2EmployeeRefSchemeClass_View : Attendance2EmployeeRefSchemeClass
    {
        [Display(Name = "_Admin.Name")]
        public String Name_view { get; set; }
        [Display(Name = "班次名")]
        public String ClassName_view { get; set; }
        public string[] Roles { get; set; }

    }
}
