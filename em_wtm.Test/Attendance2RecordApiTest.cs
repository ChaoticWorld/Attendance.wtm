using em_wtm.Controllers;
using em_wtm.DataAccess;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.Attendance2RecordVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;


namespace em_wtm.Test
{
    [TestClass]
    public class Attendance2RecordApiTest
    {
        private Attendance2RecordController _controller;
        private string _seed;

        public Attendance2RecordApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<Attendance2RecordController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new Attendance2RecordSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            Attendance2RecordVM vm = _controller.Wtm.CreateVM<Attendance2RecordVM>();
            Attendance2Record v = new Attendance2Record();

            v.ID = 32;
            v.EmployeeId = AddVAttendanceEmployee();
            v.PeriodNo = 89;
            v.SDate = DateTime.Parse("2022-12-12 16:23:40");
            v.BAttTime = new TimeSpan(1670833420);
            v.EAttTime = new TimeSpan(1670833420);
            v.BOffset = 51;
            v.EOffset = 39;
            v.BOffsetFee = 87;
            v.EOffsetFee = 44;
            v.DayTypeId = AddAttendance2DayType();
            v.PlanId = AddAttendance2PlanTime();
            v.ClassId = AddAttendance2SchemeClass();
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2Record>().Find(v.ID);

                Assert.AreEqual(data.ID, 32);
                Assert.AreEqual(data.PeriodNo, 89);
                Assert.AreEqual(data.SDate, DateTime.Parse("2022-12-12 16:23:40"));
                Assert.AreEqual(data.BAttTime, "iSLJXgVuhx");
                Assert.AreEqual(data.EAttTime, "Dfqk6xZw1Bq0Iifu");
                Assert.AreEqual(data.BOffset, 51);
                Assert.AreEqual(data.EOffset, 39);
                Assert.AreEqual(data.BOffsetFee, 87);
                Assert.AreEqual(data.EOffsetFee, 44);
            }
        }

        [TestMethod]
        public void EditTest()
        {
            Attendance2Record v = new Attendance2Record();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 32;
                v.EmployeeId = AddVAttendanceEmployee();
                v.PeriodNo = 89;
                v.SDate = DateTime.Parse("2022-12-12 16:23:40");
                v.BAttTime = new TimeSpan(1670833420);
                v.EAttTime = new TimeSpan(1670833420);
                v.BOffset = 51;
                v.EOffset = 39;
                v.BOffsetFee = 87;
                v.EOffsetFee = 44;
                v.DayTypeId = AddAttendance2DayType();
                v.PlanId = AddAttendance2PlanTime();
                v.ClassId = AddAttendance2SchemeClass();
                context.Set<Attendance2Record>().Add(v);
                context.SaveChanges();
            }

            Attendance2RecordVM vm = _controller.Wtm.CreateVM<Attendance2RecordVM>();
            var oldID = v.ID;
            v = new Attendance2Record();
            v.ID = oldID;

            v.PeriodNo = 46;
            v.SDate = DateTime.Parse("2023-11-23 16:23:40");
            v.BAttTime = new TimeSpan(1670833420);
            v.EAttTime = new TimeSpan(1670833420);
            v.BOffset = 92;
            v.EOffset = 56;
            v.BOffsetFee = 51;
            v.EOffsetFee = 79;
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.EmployeeId", "");
            vm.FC.Add("Entity.PeriodNo", "");
            vm.FC.Add("Entity.SDate", "");
            vm.FC.Add("Entity.BAttTime", "");
            vm.FC.Add("Entity.EAttTime", "");
            vm.FC.Add("Entity.BOffset", "");
            vm.FC.Add("Entity.EOffset", "");
            vm.FC.Add("Entity.BOffsetFee", "");
            vm.FC.Add("Entity.EOffsetFee", "");
            vm.FC.Add("Entity.DayTypeId", "");
            vm.FC.Add("Entity.PlanId", "");
            vm.FC.Add("Entity.ClassId", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2Record>().Find(v.ID);

                Assert.AreEqual(data.PeriodNo, 46);
                Assert.AreEqual(data.SDate, DateTime.Parse("2023-11-23 16:23:40"));
                Assert.AreEqual(data.BAttTime, "3GQV6APU");
                Assert.AreEqual(data.EAttTime, "JDaDgei9oCYIx5Riz");
                Assert.AreEqual(data.BOffset, 92);
                Assert.AreEqual(data.EOffset, 56);
                Assert.AreEqual(data.BOffsetFee, 51);
                Assert.AreEqual(data.EOffsetFee, 79);
            }

        }

        [TestMethod]
        public void GetTest()
        {
            Attendance2Record v = new Attendance2Record();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 32;
                v.EmployeeId = AddVAttendanceEmployee();
                v.PeriodNo = 89;
                v.SDate = DateTime.Parse("2022-12-12 16:23:40");
                v.BAttTime = new TimeSpan(1670833420);
                v.EAttTime = new TimeSpan(1670833420);
                v.BOffset = 51;
                v.EOffset = 39;
                v.BOffsetFee = 87;
                v.EOffsetFee = 44;
                v.DayTypeId = AddAttendance2DayType();
                v.PlanId = AddAttendance2PlanTime();
                v.ClassId = AddAttendance2SchemeClass();
                context.Set<Attendance2Record>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Attendance2Record v1 = new Attendance2Record();
            Attendance2Record v2 = new Attendance2Record();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.ID = 32;
                v1.EmployeeId = AddVAttendanceEmployee();
                v1.PeriodNo = 89;
                v1.SDate = DateTime.Parse("2022-12-12 16:23:40");
                v1.BAttTime = new TimeSpan(1670833420);
                v1.EAttTime = new TimeSpan(1670833420);
                v1.BOffset = 51;
                v1.EOffset = 39;
                v1.BOffsetFee = 87;
                v1.EOffsetFee = 44;
                v1.DayTypeId = AddAttendance2DayType();
                v1.PlanId = AddAttendance2PlanTime();
                v1.ClassId = AddAttendance2SchemeClass();
                v2.ID = 13;
                v2.EmployeeId = v1.EmployeeId;
                v2.PeriodNo = 46;
                v2.SDate = DateTime.Parse("2023-11-23 16:23:40");
                v2.BAttTime = new TimeSpan(1670833420);
                v2.EAttTime = new TimeSpan(1670833420);
                v2.BOffset = 92;
                v2.EOffset = 56;
                v2.BOffsetFee = 51;
                v2.EOffsetFee = 79;
                v2.DayTypeId = v1.DayTypeId;
                v2.PlanId = v1.PlanId;
                v2.ClassId = v1.ClassId;
                context.Set<Attendance2Record>().Add(v1);
                context.Set<Attendance2Record>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Attendance2Record>().Find(v1.ID);
                var data2 = context.Set<Attendance2Record>().Find(v2.ID);
                Assert.AreEqual(data1, null);
                Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] { });
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }

        private Int32 AddVAttendanceEmployee()
        {
            VAttendanceEmployee v = new VAttendanceEmployee();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try
                {

                    v.ID = 76;
                    v.EmployeeName = "zf";
                    context.Set<VAttendanceEmployee>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }

        private Int32 AddAttendance2DayType()
        {
            Attendance2DayType v = new Attendance2DayType();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try
                {

                    v.ID = 92;
                    v.DayTypeName = "aonnD6OHEagzbg";
                    v.DayTypeCaption = "2l4pUzuKxU";
                    context.Set<Attendance2DayType>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }

        private Int32 AddAttendance2PlanTime()
        {
            Attendance2PlanTime v = new Attendance2PlanTime();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try
                {

                    v.ID = 7;
                    v.PlanName = "PmjKuHMzZ";
                    v.DayTypeId = AddAttendance2DayType();
                    v.Description = "C";
                    context.Set<Attendance2PlanTime>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }

        private Int32 AddAttendance2SchemeClass()
        {
            Attendance2SchemeClass v = new Attendance2SchemeClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try
                {

                    v.ID = 79;
                    v.ClassName = "Hd4";
                    v.Periods = 60;
                    v.ClassDescription = "Z7";
                    v.ClassPeriods = 91;
                    context.Set<Attendance2SchemeClass>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }


    }
}
