using em_wtm.Controllers;
using em_wtm.DataAccess;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.Attendance2PlanTimeVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;


namespace em_wtm.Test
{
    [TestClass]
    public class Attendance2PlanTimeApiTest
    {
        private Attendance2PlanTimeController _controller;
        private string _seed;

        public Attendance2PlanTimeApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<Attendance2PlanTimeController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new Attendance2PlanTimeSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            Attendance2PlanTimeVM vm = _controller.Wtm.CreateVM<Attendance2PlanTimeVM>();
            Attendance2PlanTime v = new Attendance2PlanTime();

            v.ID = 89;
            v.PlanName = "Wbi5qUXCHtjLIrFx";
            v.DayTypeId = AddAttendance2DayType();
            v.Description = "WV0gFPvmmzQpIzadzq";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2PlanTime>().Find(v.ID);

                Assert.AreEqual(data.ID, 89);
                Assert.AreEqual(data.PlanName, "Wbi5qUXCHtjLIrFx");
                Assert.AreEqual(data.Description, "WV0gFPvmmzQpIzadzq");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            Attendance2PlanTime v = new Attendance2PlanTime();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 89;
                v.PlanName = "Wbi5qUXCHtjLIrFx";
                v.DayTypeId = AddAttendance2DayType();
                v.Description = "WV0gFPvmmzQpIzadzq";
                context.Set<Attendance2PlanTime>().Add(v);
                context.SaveChanges();
            }

            Attendance2PlanTimeVM vm = _controller.Wtm.CreateVM<Attendance2PlanTimeVM>();
            var oldID = v.ID;
            v = new Attendance2PlanTime();
            v.ID = oldID;

            v.PlanName = "pbXlH";
            v.Description = "rXQ136";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.PlanName", "");
            vm.FC.Add("Entity.DayTypeId", "");
            vm.FC.Add("Entity.Description", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2PlanTime>().Find(v.ID);

                Assert.AreEqual(data.PlanName, "pbXlH");
                Assert.AreEqual(data.Description, "rXQ136");
            }

        }

        [TestMethod]
        public void GetTest()
        {
            Attendance2PlanTime v = new Attendance2PlanTime();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 89;
                v.PlanName = "Wbi5qUXCHtjLIrFx";
                v.DayTypeId = AddAttendance2DayType();
                v.Description = "WV0gFPvmmzQpIzadzq";
                context.Set<Attendance2PlanTime>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Attendance2PlanTime v1 = new Attendance2PlanTime();
            Attendance2PlanTime v2 = new Attendance2PlanTime();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.ID = 89;
                v1.PlanName = "Wbi5qUXCHtjLIrFx";
                v1.DayTypeId = AddAttendance2DayType();
                v1.Description = "WV0gFPvmmzQpIzadzq";
                v2.ID = 43;
                v2.PlanName = "pbXlH";
                v2.DayTypeId = v1.DayTypeId;
                v2.Description = "rXQ136";
                context.Set<Attendance2PlanTime>().Add(v1);
                context.Set<Attendance2PlanTime>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Attendance2PlanTime>().Find(v1.ID);
                var data2 = context.Set<Attendance2PlanTime>().Find(v2.ID);
                Assert.AreEqual(data1, null);
                Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] { });
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }

        private Int32 AddAttendance2DayType()
        {
            Attendance2DayType v = new Attendance2DayType();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try
                {

                    v.ID = 51;
                    v.DayTypeName = "QeeV4A0bHyKAT";
                    v.DayTypeCaption = "gNDBFwIFnxZ";
                    context.Set<Attendance2DayType>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }


    }
}
