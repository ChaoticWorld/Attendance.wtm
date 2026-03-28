using em_wtm.Controllers;
using em_wtm.DataAccess;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.Attendance2PlanRefClassVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;


namespace em_wtm.Test
{
    [TestClass]
    public class Attendance2PlanRefClassApiTest
    {
        private Attendance2PlanRefClassController _controller;
        private string _seed;

        public Attendance2PlanRefClassApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<Attendance2PlanRefClassController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new Attendance2PlanRefClassSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            Attendance2PlanRefClassVM vm = _controller.Wtm.CreateVM<Attendance2PlanRefClassVM>();
            Attendance2PlanRefClass v = new Attendance2PlanRefClass();

            v.ID = 72;
            v.ClassId = AddAttendance2SchemeClass();
            v.PlanId = AddAttendance2PlanTime();
            v.PeriodNo = 53;
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2PlanRefClass>().Find(v.ID);

                Assert.AreEqual(data.ID, 72);
                Assert.AreEqual(data.PeriodNo, 53);
            }
        }

        [TestMethod]
        public void EditTest()
        {
            Attendance2PlanRefClass v = new Attendance2PlanRefClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 72;
                v.ClassId = AddAttendance2SchemeClass();
                v.PlanId = AddAttendance2PlanTime();
                v.PeriodNo = 53;
                context.Set<Attendance2PlanRefClass>().Add(v);
                context.SaveChanges();
            }

            Attendance2PlanRefClassVM vm = _controller.Wtm.CreateVM<Attendance2PlanRefClassVM>();
            var oldID = v.ID;
            v = new Attendance2PlanRefClass();
            v.ID = oldID;

            v.ID = 42;
            v.PeriodNo = 59;
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.Autoid", "");
            vm.FC.Add("Entity.ClassId", "");
            vm.FC.Add("Entity.PlanId", "");
            vm.FC.Add("Entity.PeriodNo", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2PlanRefClass>().Find(v.ID);

                Assert.AreEqual(data.ID, 42);
                Assert.AreEqual(data.PeriodNo, 59);
            }

        }

        [TestMethod]
        public void GetTest()
        {
            Attendance2PlanRefClass v = new Attendance2PlanRefClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 72;
                v.ClassId = AddAttendance2SchemeClass();
                v.PlanId = AddAttendance2PlanTime();
                v.PeriodNo = 53;
                context.Set<Attendance2PlanRefClass>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Attendance2PlanRefClass v1 = new Attendance2PlanRefClass();
            Attendance2PlanRefClass v2 = new Attendance2PlanRefClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.ID = 72;
                v1.ClassId = AddAttendance2SchemeClass();
                v1.PlanId = AddAttendance2PlanTime();
                v1.PeriodNo = 53;
                v2.ID = 42;
                v2.ClassId = v1.ClassId;
                v2.PlanId = v1.PlanId;
                v2.PeriodNo = 59;
                context.Set<Attendance2PlanRefClass>().Add(v1);
                context.Set<Attendance2PlanRefClass>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Attendance2PlanRefClass>().Find(v1.ID);
                var data2 = context.Set<Attendance2PlanRefClass>().Find(v2.ID);
                Assert.AreEqual(data1, null);
                Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] { });
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }

        private Int32 AddAttendance2SchemeClass()
        {
            Attendance2SchemeClass v = new Attendance2SchemeClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try
                {

                    v.ClassName = "72Sp9t9QLrzuDzWEGq";
                    v.ID = 17;
                    v.Periods = 99;
                    v.ClassDescription = "1CPNyjq5R5AqK7xl";
                    v.ClassPeriods = 33;
                    context.Set<Attendance2SchemeClass>().Add(v);
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

                    v.ID = 30;
                    v.DayTypeName = "xXgWwFYHT";
                    v.DayTypeCaption = "DyJbjH";
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

                    v.ID = 68;
                    v.PlanName = "qAu5SXJic";
                    v.DayTypeId = AddAttendance2DayType();
                    v.Description = "F6pO2eAyOygrUu1aGli";
                    context.Set<Attendance2PlanTime>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }


    }
}
