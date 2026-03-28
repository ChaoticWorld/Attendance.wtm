using em_wtm.Controllers;
using em_wtm.DataAccess;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.Attendance2FeeCalculatorVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;


namespace em_wtm.Test
{
    [TestClass]
    public class Attendance2FeeCalculatorApiTest
    {
        private Attendance2FeeCalculatorController _controller;
        private string _seed;

        public Attendance2FeeCalculatorApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<Attendance2FeeCalculatorController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new Attendance2FeeCalculatorSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            Attendance2FeeCalculatorVM vm = _controller.Wtm.CreateVM<Attendance2FeeCalculatorVM>();
            Attendance2FeeCalculator v = new Attendance2FeeCalculator();

            v.ID = 62;
            v.DayTypeId = AddAttendance2DayType();
            v.RangeA = 66;
            v.RangeB = 3;
            v.RangePrice = 54;
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2FeeCalculator>().Find(v.ID);

                Assert.AreEqual(data.ID, 62);
                Assert.AreEqual(data.RangeA, 66);
                Assert.AreEqual(data.RangeB, 3);
                Assert.AreEqual(data.RangePrice, 54);
            }
        }

        [TestMethod]
        public void EditTest()
        {
            Attendance2FeeCalculator v = new Attendance2FeeCalculator();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 62;
                v.DayTypeId = AddAttendance2DayType();
                v.RangeA = 66;
                v.RangeB = 3;
                v.RangePrice = 54;
                context.Set<Attendance2FeeCalculator>().Add(v);
                context.SaveChanges();
            }

            Attendance2FeeCalculatorVM vm = _controller.Wtm.CreateVM<Attendance2FeeCalculatorVM>();
            var oldID = v.ID;
            v = new Attendance2FeeCalculator();
            v.ID = oldID;

            v.RangeA = 2;
            v.RangeB = 67;
            v.RangePrice = 94;
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.DayTypeId", "");
            vm.FC.Add("Entity.RangeA", "");
            vm.FC.Add("Entity.RangeB", "");
            vm.FC.Add("Entity.RangePrice", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2FeeCalculator>().Find(v.ID);

                Assert.AreEqual(data.RangeA, 2);
                Assert.AreEqual(data.RangeB, 67);
                Assert.AreEqual(data.RangePrice, 94);
            }

        }

        [TestMethod]
        public void GetTest()
        {
            Attendance2FeeCalculator v = new Attendance2FeeCalculator();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ID = 62;
                v.DayTypeId = AddAttendance2DayType();
                v.RangeA = 66;
                v.RangeB = 3;
                v.RangePrice = 54;
                context.Set<Attendance2FeeCalculator>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Attendance2FeeCalculator v1 = new Attendance2FeeCalculator();
            Attendance2FeeCalculator v2 = new Attendance2FeeCalculator();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.ID = 62;
                v1.DayTypeId = AddAttendance2DayType();
                v1.RangeA = 66;
                v1.RangeB = 3;
                v1.RangePrice = 54;
                v2.ID = 44;
                v2.DayTypeId = v1.DayTypeId;
                v2.RangeA = 2;
                v2.RangeB = 67;
                v2.RangePrice = 94;
                context.Set<Attendance2FeeCalculator>().Add(v1);
                context.Set<Attendance2FeeCalculator>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Attendance2FeeCalculator>().Find(v1.ID);
                var data2 = context.Set<Attendance2FeeCalculator>().Find(v2.ID);
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

                    v.ID = 19;
                    v.DayTypeName = "1";
                    v.DayTypeCaption = "s5gVAV0fA";
                    context.Set<Attendance2DayType>().Add(v);
                    context.SaveChanges();
                }
                catch { }
            }
            return v.ID;
        }


    }
}
