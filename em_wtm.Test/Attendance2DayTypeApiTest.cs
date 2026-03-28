using em_wtm.Controllers;
using em_wtm.DataAccess;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.Attendance2DayTypeVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;


namespace em_wtm.Test
{
    [TestClass]
    public class Attendance2DayTypeApiTest
    {
        private Attendance2DayTypeController _controller;
        private string _seed;

        public Attendance2DayTypeApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<Attendance2DayTypeController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new Attendance2DayTypeSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            Attendance2DayTypeVM vm = _controller.Wtm.CreateVM<Attendance2DayTypeVM>();
            Attendance2DayType v = new Attendance2DayType();

            v.ID = 12;
            v.DayTypeName = "sXAgLgb";
            v.DayTypeCaption = "xgWG76Cou6A4wPr2";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2DayType>().Find(v.ID);

                Assert.AreEqual(data.ID, 12);
                Assert.AreEqual(data.DayTypeName, "sXAgLgb");
                Assert.AreEqual(data.DayTypeCaption, "xgWG76Cou6A4wPr2");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            Attendance2DayType v = new Attendance2DayType();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 12;
                v.DayTypeName = "sXAgLgb";
                v.DayTypeCaption = "xgWG76Cou6A4wPr2";
                context.Set<Attendance2DayType>().Add(v);
                context.SaveChanges();
            }

            Attendance2DayTypeVM vm = _controller.Wtm.CreateVM<Attendance2DayTypeVM>();
            var oldID = v.ID;
            v = new Attendance2DayType();
            v.ID = oldID;

            v.DayTypeName = "RJ";
            v.DayTypeCaption = "wyY3DYhIV5zgeUk";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.DayTypeName", "");
            vm.FC.Add("Entity.DayTypeCaption", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2DayType>().Find(v.ID);

                Assert.AreEqual(data.DayTypeName, "RJ");
                Assert.AreEqual(data.DayTypeCaption, "wyY3DYhIV5zgeUk");
            }

        }

        [TestMethod]
        public void GetTest()
        {
            Attendance2DayType v = new Attendance2DayType();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 12;
                v.DayTypeName = "sXAgLgb";
                v.DayTypeCaption = "xgWG76Cou6A4wPr2";
                context.Set<Attendance2DayType>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Attendance2DayType v1 = new Attendance2DayType();
            Attendance2DayType v2 = new Attendance2DayType();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.ID = 12;
                v1.DayTypeName = "sXAgLgb";
                v1.DayTypeCaption = "xgWG76Cou6A4wPr2";
                v2.ID = 20;
                v2.DayTypeName = "RJ";
                v2.DayTypeCaption = "wyY3DYhIV5zgeUk";
                context.Set<Attendance2DayType>().Add(v1);
                context.Set<Attendance2DayType>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Attendance2DayType>().Find(v1.ID);
                var data2 = context.Set<Attendance2DayType>().Find(v2.ID);
                Assert.AreEqual(data1, null);
                Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] { });
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }


    }
}
