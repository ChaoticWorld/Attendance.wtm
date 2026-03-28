using em_wtm.Controllers;
using em_wtm.DataAccess;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.Attendance2HolidayVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;


namespace em_wtm.Test
{
    [TestClass]
    public class Attendance2HolidayApiTest
    {
        private Attendance2HolidayController _controller;
        private string _seed;

        public Attendance2HolidayApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<Attendance2HolidayController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new Attendance2HolidaySearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            Attendance2HolidayVM vm = _controller.Wtm.CreateVM<Attendance2HolidayVM>();
            Attendance2Holiday v = new Attendance2Holiday();

            v.ID = 24;
            v.IYear = 60;
            v.SDate = DateTime.Parse("2022-12-04 15:57:48");
            v.SName = "pkCBLgJTD1fh8p7ph";
            v.SDescription = "ygN2wR";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2Holiday>().Find(v.ID);

                Assert.AreEqual(data.ID, 24);
                Assert.AreEqual(data.IYear, 60);
                Assert.AreEqual(data.SDate, DateTime.Parse("2022-12-04 15:57:48"));
                Assert.AreEqual(data.SName, "pkCBLgJTD1fh8p7ph");
                Assert.AreEqual(data.SDescription, "ygN2wR");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            Attendance2Holiday v = new Attendance2Holiday();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 24;
                v.IYear = 60;
                v.SDate = DateTime.Parse("2022-12-04 15:57:48");
                v.SName = "pkCBLgJTD1fh8p7ph";
                v.SDescription = "ygN2wR";
                context.Set<Attendance2Holiday>().Add(v);
                context.SaveChanges();
            }

            Attendance2HolidayVM vm = _controller.Wtm.CreateVM<Attendance2HolidayVM>();
            var oldID = v.ID;
            v = new Attendance2Holiday();
            v.ID = oldID;

            v.IYear = 13;
            v.SDate = DateTime.Parse("2024-04-10 15:57:48");
            v.SName = "hpImQdyD5";
            v.SDescription = "2jiEA";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.IYear", "");
            vm.FC.Add("Entity.SDate", "");
            vm.FC.Add("Entity.SName", "");
            vm.FC.Add("Entity.SDescription", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2Holiday>().Find(v.ID);

                Assert.AreEqual(data.IYear, 13);
                Assert.AreEqual(data.SDate, DateTime.Parse("2024-04-10 15:57:48"));
                Assert.AreEqual(data.SName, "hpImQdyD5");
                Assert.AreEqual(data.SDescription, "2jiEA");
            }

        }

        [TestMethod]
        public void GetTest()
        {
            Attendance2Holiday v = new Attendance2Holiday();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 24;
                v.IYear = 60;
                v.SDate = DateTime.Parse("2022-12-04 15:57:48");
                v.SName = "pkCBLgJTD1fh8p7ph";
                v.SDescription = "ygN2wR";
                context.Set<Attendance2Holiday>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Attendance2Holiday v1 = new Attendance2Holiday();
            Attendance2Holiday v2 = new Attendance2Holiday();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.ID = 24;
                v1.IYear = 60;
                v1.SDate = DateTime.Parse("2022-12-04 15:57:48");
                v1.SName = "pkCBLgJTD1fh8p7ph";
                v1.SDescription = "ygN2wR";
                v2.ID = 99;
                v2.IYear = 13;
                v2.SDate = DateTime.Parse("2024-04-10 15:57:48");
                v2.SName = "hpImQdyD5";
                v2.SDescription = "2jiEA";
                context.Set<Attendance2Holiday>().Add(v1);
                context.Set<Attendance2Holiday>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Attendance2Holiday>().Find(v1.ID);
                var data2 = context.Set<Attendance2Holiday>().Find(v2.ID);
                Assert.AreEqual(data1, null);
                Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] { });
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }


    }
}
