using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using em_wtm.Controllers;
using em_wtm.ViewModel.Report.ReportMainVMs;
using em_wtm.Model._Business.Report;
using em_wtm.DataAccess;


namespace em_wtm.Test
{
    [TestClass]
    public class ReportMainApiTest
    {
        private ReportMainController _controller;
        private string _seed;

        public ReportMainApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<ReportMainController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new ReportMainSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content)==false);
        }

        [TestMethod]
        public void CreateTest()
        {
            ReportMainVM vm = _controller.Wtm.CreateVM<ReportMainVM>();
            ReportMain v = new ReportMain();
            
            v.ID = 0;
            v.Description = "sNAyClgde8Yc";
            v.Name = "QKoSgwyef9Vm4H";
            v.Title = "BQ2XnnZvdRQls";
            v.DBConnection = "bme";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportMain>().Find(v.ID);
                
                Assert.AreEqual(data.ID, 0);
                Assert.AreEqual(data.Description, "sNAyClgde8Yc");
                Assert.AreEqual(data.Name, "QKoSgwyef9Vm4H");
                Assert.AreEqual(data.Title, "BQ2XnnZvdRQls");
                Assert.AreEqual(data.DBConnection, "bme");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            ReportMain v = new ReportMain();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.ID = 0;
                v.Description = "sNAyClgde8Yc";
                v.Name = "QKoSgwyef9Vm4H";
                v.Title = "BQ2XnnZvdRQls";
                v.DBConnection = "bme";
                context.Set<ReportMain>().Add(v);
                context.SaveChanges();
            }

            ReportMainVM vm = _controller.Wtm.CreateVM<ReportMainVM>();
            var oldID = v.ID;
            v = new ReportMain();
            v.ID = oldID;
       		
            v.Description = "KLlU542Tkvxb39fjPdp";
            v.Name = "iebC";
            v.Title = "n2o9uqDn";
            v.DBConnection = "I7hvCaJBQm8PT";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.Description", "");
            vm.FC.Add("Entity.Name", "");
            vm.FC.Add("Entity.Title", "");
            vm.FC.Add("Entity.DBConnection", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportMain>().Find(v.ID);
 				
                Assert.AreEqual(data.Description, "KLlU542Tkvxb39fjPdp");
                Assert.AreEqual(data.Name, "iebC");
                Assert.AreEqual(data.Title, "n2o9uqDn");
                Assert.AreEqual(data.DBConnection, "I7hvCaJBQm8PT");
            }

        }

		[TestMethod]
        public void GetTest()
        {
            ReportMain v = new ReportMain();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.ID = 0;
                v.Description = "sNAyClgde8Yc";
                v.Name = "QKoSgwyef9Vm4H";
                v.Title = "BQ2XnnZvdRQls";
                v.DBConnection = "bme";
                context.Set<ReportMain>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            ReportMain v1 = new ReportMain();
            ReportMain v2 = new ReportMain();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.ID = 0;
                v1.Description = "sNAyClgde8Yc";
                v1.Name = "QKoSgwyef9Vm4H";
                v1.Title = "BQ2XnnZvdRQls";
                v1.DBConnection = "bme";
                v2.ID = 5;
                v2.Description = "KLlU542Tkvxb39fjPdp";
                v2.Name = "iebC";
                v2.Title = "n2o9uqDn";
                v2.DBConnection = "I7hvCaJBQm8PT";
                context.Set<ReportMain>().Add(v1);
                context.Set<ReportMain>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<ReportMain>().Find(v1.ID);
                var data2 = context.Set<ReportMain>().Find(v2.ID);
                Assert.AreEqual(data1, null);
            Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] {});
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }


    }
}
