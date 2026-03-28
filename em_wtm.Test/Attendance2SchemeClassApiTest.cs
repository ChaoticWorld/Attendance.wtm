using em_wtm.Controllers;
using em_wtm.DataAccess;
using em_wtm.Model._Business.Attendance;
using em_wtm.ViewModel.Attendance.Attendance2SchemeClassVMs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WalkingTec.Mvvm.Core;


namespace em_wtm.Test
{
    [TestClass]
    public class Attendance2SchemeClassApiTest
    {
        private Attendance2SchemeClassController _controller;
        private string _seed;

        public Attendance2SchemeClassApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<Attendance2SchemeClassController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new Attendance2SchemeClassSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content) == false);
        }

        [TestMethod]
        public void CreateTest()
        {
            Attendance2SchemeClassVM vm = _controller.Wtm.CreateVM<Attendance2SchemeClassVM>();
            Attendance2SchemeClass v = new Attendance2SchemeClass();

            v.ClassName = "K8VO2IxQVmncWSk25";
            v.ID = 50;
            v.Periods = 1;
            v.ClassDescription = "yAL0Pfz7pODXV";
            v.ClassPeriods = 94;
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2SchemeClass>().Find(v.ID);

                Assert.AreEqual(data.ClassName, "K8VO2IxQVmncWSk25");
                Assert.AreEqual(data.ID, 50);
                Assert.AreEqual(data.Periods, 1);
                Assert.AreEqual(data.ClassDescription, "yAL0Pfz7pODXV");
                Assert.AreEqual(data.ClassPeriods, 94);
            }
        }

        [TestMethod]
        public void EditTest()
        {
            Attendance2SchemeClass v = new Attendance2SchemeClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ClassName = "K8VO2IxQVmncWSk25";
                v.ID = 50;
                v.Periods = 1;
                v.ClassDescription = "yAL0Pfz7pODXV";
                v.ClassPeriods = 94;
                context.Set<Attendance2SchemeClass>().Add(v);
                context.SaveChanges();
            }

            Attendance2SchemeClassVM vm = _controller.Wtm.CreateVM<Attendance2SchemeClassVM>();
            var oldID = v.ID;
            v = new Attendance2SchemeClass();
            v.ID = oldID;

            v.ClassName = "KGQ7k8Ibef";
            v.Periods = 90;
            v.ClassDescription = "Jbm0XO";
            v.ClassPeriods = 67;
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();

            vm.FC.Add("Entity.ClassName", "");
            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.Periods", "");
            vm.FC.Add("Entity.ClassDescription", "");
            vm.FC.Add("Entity.ClassPeriods", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<Attendance2SchemeClass>().Find(v.ID);

                Assert.AreEqual(data.ClassName, "KGQ7k8Ibef");
                Assert.AreEqual(data.Periods, 90);
                Assert.AreEqual(data.ClassDescription, "Jbm0XO");
                Assert.AreEqual(data.ClassPeriods, 67);
            }

        }

        [TestMethod]
        public void GetTest()
        {
            Attendance2SchemeClass v = new Attendance2SchemeClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v.ClassName = "K8VO2IxQVmncWSk25";
                v.ID = 50;
                v.Periods = 1;
                v.ClassDescription = "yAL0Pfz7pODXV";
                v.ClassPeriods = 94;
                context.Set<Attendance2SchemeClass>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            Attendance2SchemeClass v1 = new Attendance2SchemeClass();
            Attendance2SchemeClass v2 = new Attendance2SchemeClass();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {

                v1.ClassName = "K8VO2IxQVmncWSk25";
                v1.ID = 50;
                v1.Periods = 1;
                v1.ClassDescription = "yAL0Pfz7pODXV";
                v1.ClassPeriods = 94;
                v2.ClassName = "KGQ7k8Ibef";
                v2.ID = 86;
                v2.Periods = 90;
                v2.ClassDescription = "Jbm0XO";
                v2.ClassPeriods = 67;
                context.Set<Attendance2SchemeClass>().Add(v1);
                context.Set<Attendance2SchemeClass>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<Attendance2SchemeClass>().Find(v1.ID);
                var data2 = context.Set<Attendance2SchemeClass>().Find(v2.ID);
                Assert.AreEqual(data1, null);
                Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] { });
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }


    }
}
