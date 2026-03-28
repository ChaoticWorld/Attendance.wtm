using em_wtm.Controllers;
using em_wtm.DataAccess;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.VAttendanceReportVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;


namespace em_wtm.Test
{
    [TestClass]
    public class VAttendanceReportApiTest
    {
        private VAttendanceReportController _controller;
        private string _seed;

        public VAttendanceReportApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<VAttendanceReportController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new VAttendanceReportSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            VAttendanceReportVM vm = _controller.Wtm.CreateVM<VAttendanceReportVM>();
            VAttendanceReport v = new VAttendanceReport();

            v.ID = 2;
            v.EmployeeId = AddVAttendanceEmployee();
            v.SDate = DateTime.Parse("2023-08-04 13:28:29");
            v.Description = "MW1vD";
            v.BAttTime = new TimeSpan(1670833420);
            v.BOffset = 56;
            v.EAttTime = new TimeSpan(1670833420);
            v.EOffset = 3;
            v.Event = "sxRndIc3bM";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<VAttendanceReport>().Find(v.ID);

                Assert.AreEqual(data.ID, 2);
                Assert.AreEqual(data.SDate, DateTime.Parse("2023-08-04 13:28:29"));
                Assert.AreEqual(data.Description, "MW1vD");
                Assert.AreEqual(data.BAttTime, "87NeQS0F");
                Assert.AreEqual(data.BOffset, 56);
                Assert.AreEqual(data.EAttTime, "jRBNRFqi4AJYX3");
                Assert.AreEqual(data.EOffset, 3);
                Assert.AreEqual(data.Event, "sxRndIc3bM");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            VAttendanceReport v = new VAttendanceReport();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 2;
                v.EmployeeId = AddVAttendanceEmployee();
                v.SDate = DateTime.Parse("2023-08-04 13:28:29");
                v.Description = "MW1vD";
                v.BAttTime = new TimeSpan(1670833420);
                v.BOffset = 56;
                v.EAttTime = new TimeSpan(1670833420);
                v.EOffset = 3;
                v.Event = "sxRndIc3bM";
                context.Set<VAttendanceReport>().Add(v);
                context.SaveChanges();
            }

            VAttendanceReportVM vm = _controller.Wtm.CreateVM<VAttendanceReportVM>();
            var oldID = v.ID;
            v = new VAttendanceReport();
            v.ID = oldID;

            v.SDate = DateTime.Parse("2023-11-28 13:28:29");
            v.Description = "c6";
            v.BAttTime = new TimeSpan(1670833420);
            v.BOffset = 8;
            v.EAttTime = new TimeSpan(1670833420);
            v.EOffset = 66;
            v.Event = "f";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.EmployeeId", "");
            vm.FC.Add("Entity.SDate", "");
            vm.FC.Add("Entity.Description", "");
            vm.FC.Add("Entity.BAttTime", "");
            vm.FC.Add("Entity.BOffset", "");
            vm.FC.Add("Entity.EAttTime", "");
            vm.FC.Add("Entity.EOffset", "");
            vm.FC.Add("Entity.Event", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<VAttendanceReport>().Find(v.ID);

                Assert.AreEqual(data.SDate, DateTime.Parse("2023-11-28 13:28:29"));
                Assert.AreEqual(data.Description, "c6");
                Assert.AreEqual(data.BAttTime, "FvoxB");
                Assert.AreEqual(data.BOffset, 8);
                Assert.AreEqual(data.EAttTime, "x");
                Assert.AreEqual(data.EOffset, 66);
                Assert.AreEqual(data.Event, "f");
            }

        }

        [TestMethod]
        public void GetTest()
        {
            VAttendanceReport v = new VAttendanceReport();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 2;
                v.EmployeeId = AddVAttendanceEmployee();
                v.SDate = DateTime.Parse("2023-08-04 13:28:29");
                v.Description = "MW1vD";
                v.BAttTime = new TimeSpan(1670833420);
                v.BOffset = 56;
                v.EAttTime = new TimeSpan(1670833420);
                v.EOffset = 3;
                v.Event = "sxRndIc3bM";
                context.Set<VAttendanceReport>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            VAttendanceReport v1 = new VAttendanceReport();
            VAttendanceReport v2 = new VAttendanceReport();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.ID = 2;
                v1.EmployeeId = AddVAttendanceEmployee();
                v1.SDate = DateTime.Parse("2023-08-04 13:28:29");
                v1.Description = "MW1vD";
                v1.BAttTime = new TimeSpan(1670833420);
                v1.BOffset = 56;
                v1.EAttTime = new TimeSpan(1670833420);
                v1.EOffset = 3;
                v1.Event = "sxRndIc3bM";
                v2.ID = 93;
                v2.EmployeeId = v1.EmployeeId;
                v2.SDate = DateTime.Parse("2023-11-28 13:28:29");
                v2.Description = "c6";
                v2.BAttTime = new TimeSpan(1670833420);
                v2.BOffset = 8;
                v2.EAttTime = new TimeSpan(1670833420);
                v2.EOffset = 66;
                v2.Event = "f";
                context.Set<VAttendanceReport>().Add(v1);
                context.Set<VAttendanceReport>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<VAttendanceReport>().Find(v1.ID);
                var data2 = context.Set<VAttendanceReport>().Find(v2.ID);
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

                    v.ID = 88;
                    v.EmployeeName = "ssqSz7";
                    context.Set<VAttendanceEmployee>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }


    }
}
