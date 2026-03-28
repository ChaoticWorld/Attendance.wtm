using em_wtm.Controllers;
using em_wtm.DataAccess;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.Attendance2EventDeclaredVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;


namespace em_wtm.Test
{
    [TestClass]
    public class Attendance2EventDeclaredApiTest
    {
        private Attendance2EventDeclaredController _controller;
        private string _seed;

        public Attendance2EventDeclaredApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<Attendance2EventDeclaredController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new Attendance2EventDeclaredSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            Attendance2EventDeclaredVM vm = _controller.Wtm.CreateVM<Attendance2EventDeclaredVM>();
            Attendance2EventDeclared v = new Attendance2EventDeclared();

            v.ID = 16;
            v.EventDescription = "M8eywacaswy";
            v.Fee = 9;
            v.Memo = "rWvwL";
            v.CheckMan = "t2am7PlSI";
            v.Manager = "BlGgKkYiYuk20EKpgz";
            v.RecordId = AddAttendance2Record();
            v.IsBeginTime = true;
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2EventDeclared>().Find(v.ID);

                Assert.AreEqual(data.ID, 16);
                Assert.AreEqual(data.EventDescription, "M8eywacaswy");
                Assert.AreEqual(data.Fee, 9);
                Assert.AreEqual(data.Memo, "rWvwL");
                Assert.AreEqual(data.CheckMan, "t2am7PlSI");
                Assert.AreEqual(data.Manager, "BlGgKkYiYuk20EKpgz");
                Assert.AreEqual(data.IsBeginTime, true);
            }
        }

        [TestMethod]
        public void EditTest()
        {
            Attendance2EventDeclared v = new Attendance2EventDeclared();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 16;
                v.EventDescription = "M8eywacaswy";
                v.Fee = 9;
                v.Memo = "rWvwL";
                v.CheckMan = "t2am7PlSI";
                v.Manager = "BlGgKkYiYuk20EKpgz";
                v.RecordId = AddAttendance2Record();
                v.IsBeginTime = true;
                context.Set<Attendance2EventDeclared>().Add(v);
                context.SaveChanges();
            }

            Attendance2EventDeclaredVM vm = _controller.Wtm.CreateVM<Attendance2EventDeclaredVM>();
            var oldID = v.ID;
            v = new Attendance2EventDeclared();
            v.ID = oldID;

            v.EventDescription = "DpVuf";
            v.Fee = 8;
            v.Memo = "kXs8qq";
            v.CheckMan = "PxbQuMrWo9E";
            v.Manager = "Vm5zw";
            v.IsBeginTime = true;
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.EventDescription", "");
            vm.FC.Add("Entity.Fee", "");
            vm.FC.Add("Entity.Memo", "");
            vm.FC.Add("Entity.CheckMan", "");
            vm.FC.Add("Entity.Manager", "");
            vm.FC.Add("Entity.RecordId", "");
            vm.FC.Add("Entity.IsBeginTime", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2EventDeclared>().Find(v.ID);

                Assert.AreEqual(data.EventDescription, "DpVuf");
                Assert.AreEqual(data.Fee, 8);
                Assert.AreEqual(data.Memo, "kXs8qq");
                Assert.AreEqual(data.CheckMan, "PxbQuMrWo9E");
                Assert.AreEqual(data.Manager, "Vm5zw");
                Assert.AreEqual(data.IsBeginTime, true);
            }

        }

        [TestMethod]
        public void GetTest()
        {
            Attendance2EventDeclared v = new Attendance2EventDeclared();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 16;
                v.EventDescription = "M8eywacaswy";
                v.Fee = 9;
                v.Memo = "rWvwL";
                v.CheckMan = "t2am7PlSI";
                v.Manager = "BlGgKkYiYuk20EKpgz";
                v.RecordId = AddAttendance2Record();
                v.IsBeginTime = true;
                context.Set<Attendance2EventDeclared>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Attendance2EventDeclared v1 = new Attendance2EventDeclared();
            Attendance2EventDeclared v2 = new Attendance2EventDeclared();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.ID = 16;
                v1.EventDescription = "M8eywacaswy";
                v1.Fee = 9;
                v1.Memo = "rWvwL";
                v1.CheckMan = "t2am7PlSI";
                v1.Manager = "BlGgKkYiYuk20EKpgz";
                v1.RecordId = AddAttendance2Record();
                v1.IsBeginTime = true;
                v2.ID = 68;
                v2.EventDescription = "DpVuf";
                v2.Fee = 8;
                v2.Memo = "kXs8qq";
                v2.CheckMan = "PxbQuMrWo9E";
                v2.Manager = "Vm5zw";
                v2.RecordId = v1.RecordId;
                v2.IsBeginTime = true;
                context.Set<Attendance2EventDeclared>().Add(v1);
                context.Set<Attendance2EventDeclared>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Attendance2EventDeclared>().Find(v1.ID);
                var data2 = context.Set<Attendance2EventDeclared>().Find(v2.ID);
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

                    v.ID = 5;
                    v.EmployeeName = "LiyGSiKDerbtsg";
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

                    v.ID = 29;
                    v.DayTypeName = "uSD";
                    v.DayTypeCaption = "L6";
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

                    v.ID = 37;
                    v.PlanName = "0XYndnbsgC2MnmZdQ";
                    v.DayTypeId = AddAttendance2DayType();
                    v.Description = "BHULlJEo22X1MYRcD";
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

                    v.ID = 40;
                    v.ClassName = "DXc6xV9QLE";
                    v.Periods = 13;
                    v.ClassDescription = "uUC3KBVZNlhP8fySo";
                    v.ClassPeriods = 34;
                    context.Set<Attendance2SchemeClass>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }

        private Int32 AddAttendance2Record()
        {
            Attendance2Record v = new Attendance2Record();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try
                {

                    v.ID = 56;
                    v.EmployeeId = AddVAttendanceEmployee();
                    v.PeriodNo = 32;
                    v.SDate = DateTime.Parse("2023-12-07 14:42:49");
                    v.BAttTime = new TimeSpan(9, 0, 0);
                    v.EAttTime = new TimeSpan(17, 0, 0);
                    v.BOffset = 27;
                    v.EOffset = 92;
                    v.BOffsetFee = 98;
                    v.EOffsetFee = 9;
                    v.DayTypeId = AddAttendance2DayType();
                    v.PlanId = AddAttendance2PlanTime();
                    v.ClassId = AddAttendance2SchemeClass();
                    context.Set<Attendance2Record>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }


    }
}
