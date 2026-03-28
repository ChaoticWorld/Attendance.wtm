using em_wtm.Controllers;
using em_wtm.DataAccess;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.Attendance2EmployeeRefSchemeClassVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;


namespace em_wtm.Test
{
    [TestClass]
    public class Attendance2EmployeeRefSchemeClassApiTest
    {
        private Attendance2EmployeeRefSchemeClassController _controller;
        private string _seed;

        public Attendance2EmployeeRefSchemeClassApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<Attendance2EmployeeRefSchemeClassController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new Attendance2EmployeeRefSchemeClassSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            Attendance2EmployeeRefSchemeClassVM vm = _controller.Wtm.CreateVM<Attendance2EmployeeRefSchemeClassVM>();
            Attendance2EmployeeRefSchemeClass v = new Attendance2EmployeeRefSchemeClass();

            v.ID = 81;
            v.UserId = AddFrameworkUser();
            v.EmployeeId = 90;
            v.ClassId = AddAttendance2SchemeClass();
            v.EffDate = DateTime.Parse("2023-01-08 16:01:37");
            v.PeriodNo = 50;
            v.ExpDate = DateTime.Parse("2022-09-19 16:01:37");
            v.EmployeeName = "nG6D";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2EmployeeRefSchemeClass>().Find(v.ID);

                Assert.AreEqual(data.ID, 81);
                Assert.AreEqual(data.EmployeeId, 90);
                Assert.AreEqual(data.EffDate, DateTime.Parse("2023-01-08 16:01:37"));
                Assert.AreEqual(data.PeriodNo, 50);
                Assert.AreEqual(data.ExpDate, DateTime.Parse("2022-09-19 16:01:37"));
                Assert.AreEqual(data.EmployeeName, "nG6D");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            Attendance2EmployeeRefSchemeClass v = new Attendance2EmployeeRefSchemeClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 81;
                v.UserId = AddFrameworkUser();
                v.EmployeeId = 90;
                v.ClassId = AddAttendance2SchemeClass();
                v.EffDate = DateTime.Parse("2023-01-08 16:01:37");
                v.PeriodNo = 50;
                v.ExpDate = DateTime.Parse("2022-09-19 16:01:37");
                v.EmployeeName = "nG6D";
                context.Set<Attendance2EmployeeRefSchemeClass>().Add(v);
                context.SaveChanges();
            }

            Attendance2EmployeeRefSchemeClassVM vm = _controller.Wtm.CreateVM<Attendance2EmployeeRefSchemeClassVM>();
            var oldID = v.ID;
            v = new Attendance2EmployeeRefSchemeClass();
            v.ID = oldID;

            v.ID = 42;
            v.EmployeeId = 61;
            v.EffDate = DateTime.Parse("2024-03-25 16:01:37");
            v.PeriodNo = 32;
            v.ExpDate = DateTime.Parse("2022-06-29 16:01:37");
            v.EmployeeName = "ivDJjQNps60ZAAEUF";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.Autoid", "");
            vm.FC.Add("Entity.UserId", "");
            vm.FC.Add("Entity.EmployeeId", "");
            vm.FC.Add("Entity.ClassId", "");
            vm.FC.Add("Entity.EffDate", "");
            vm.FC.Add("Entity.PeriodNo", "");
            vm.FC.Add("Entity.ExpDate", "");
            vm.FC.Add("Entity.EmployeeName", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2EmployeeRefSchemeClass>().Find(v.ID);

                Assert.AreEqual(data.ID, 42);
                Assert.AreEqual(data.EmployeeId, 61);
                Assert.AreEqual(data.EffDate, DateTime.Parse("2024-03-25 16:01:37"));
                Assert.AreEqual(data.PeriodNo, 32);
                Assert.AreEqual(data.ExpDate, DateTime.Parse("2022-06-29 16:01:37"));
                Assert.AreEqual(data.EmployeeName, "ivDJjQNps60ZAAEUF");
            }

        }

        [TestMethod]
        public void GetTest()
        {
            Attendance2EmployeeRefSchemeClass v = new Attendance2EmployeeRefSchemeClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 81;
                v.UserId = AddFrameworkUser();
                v.EmployeeId = 90;
                v.ClassId = AddAttendance2SchemeClass();
                v.EffDate = DateTime.Parse("2023-01-08 16:01:37");
                v.PeriodNo = 50;
                v.ExpDate = DateTime.Parse("2022-09-19 16:01:37");
                v.EmployeeName = "nG6D";
                context.Set<Attendance2EmployeeRefSchemeClass>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Attendance2EmployeeRefSchemeClass v1 = new Attendance2EmployeeRefSchemeClass();
            Attendance2EmployeeRefSchemeClass v2 = new Attendance2EmployeeRefSchemeClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.ID = 81;
                v1.UserId = AddFrameworkUser();
                v1.EmployeeId = 90;
                v1.ClassId = AddAttendance2SchemeClass();
                v1.EffDate = DateTime.Parse("2023-01-08 16:01:37");
                v1.PeriodNo = 50;
                v1.ExpDate = DateTime.Parse("2022-09-19 16:01:37");
                v1.EmployeeName = "nG6D";
                v2.ID = 42;
                v2.UserId = v1.UserId;
                v2.EmployeeId = 61;
                v2.ClassId = v1.ClassId;
                v2.EffDate = DateTime.Parse("2024-03-25 16:01:37");
                v2.PeriodNo = 32;
                v2.ExpDate = DateTime.Parse("2022-06-29 16:01:37");
                v2.EmployeeName = "ivDJjQNps60ZAAEUF";
                context.Set<Attendance2EmployeeRefSchemeClass>().Add(v1);
                context.Set<Attendance2EmployeeRefSchemeClass>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Attendance2EmployeeRefSchemeClass>().Find(v1.ID);
                var data2 = context.Set<Attendance2EmployeeRefSchemeClass>().Find(v2.ID);
                Assert.AreEqual(data1, null);
                Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] { });
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }

        private Guid AddFileAttachment()
        {
            FileAttachment v = new FileAttachment();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try
                {

                    v.FileName = "5";
                    v.FileExt = "x";
                    v.Path = "Za7TC8OKBa";
                    v.Length = 46;
                    v.UploadTime = DateTime.Parse("2022-11-16 16:01:37");
                    v.SaveMode = "V5EM2ggb4qzwjNDs5V4";
                    v.ExtraInfo = "1LnEUmdCMea9vK1I";
                    v.HandlerInfo = "1mwAkRSoM";
                    context.Set<FileAttachment>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }

        private Guid AddFrameworkUser()
        {
            FrameworkUser v = new FrameworkUser();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try
                {

                    v.Email = "zNRSZxMwK";
                    v.Gender = WalkingTec.Mvvm.Core.GenderEnum.Female;
                    v.HomePhone = "0EvENKLAy7xwNDtYyS";
                    v.Address = "3MmPjFatuTbNvfXIDsHylOZXdFiLiiUrXcHdp";
                    v.ZipCode = "tBGMtcOVB";
                    v.CellPhone = "T0L0Tj7O";
                    v.ITCode = "81eS7TkWtc0ldjaRigEuLFRPzIRLPEYBPeCvlGknF88B0zzi";
                    v.Password = "cJzn";
                    v.Name = "Sq00hVaXPCxRodLaeQxfDoVhBlCSAvA8JJcc1ZOSd28c";
                    v.IsValid = true;
                    v.PhotoId = AddFileAttachment();
                    context.Set<FrameworkUser>().Add(v);
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

                    v.ClassName = "LZNaqY6In5Llv";
                    v.ID = 67;
                    v.Periods = 35;
                    v.ClassDescription = "u";
                    v.ClassPeriods = 46;
                    context.Set<Attendance2SchemeClass>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }


    }
}
