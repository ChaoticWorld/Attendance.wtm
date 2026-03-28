using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using em_wtm.Controllers;
using em_wtm.ViewModel.Report.ReportScriptTypeEnumVMs;
using em_wtm.Model._Business.Report;
using em_wtm.DataAccess;


namespace em_wtm.Test
{
    [TestClass]
    public class ReportScriptTypeEnumApiTest
    {
        private ReportScriptTypeEnumController _controller;
        private string _seed;

        public ReportScriptTypeEnumApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<ReportScriptTypeEnumController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new ReportScriptTypeEnumSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content)==false);
        }

        [TestMethod]
        public void CreateTest()
        {
            ReportScriptTypeEnumVM vm = _controller.Wtm.CreateVM<ReportScriptTypeEnumVM>();
            ReportScriptTypeEnum v = new ReportScriptTypeEnum();
            
            v.ID = 49;
            v.Name = "HqqmQt6JwVM69f";
            v.Module = "ekHtZ";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportScriptTypeEnum>().Find(v.ID);
                
                Assert.AreEqual(data.ID, 49);
                Assert.AreEqual(data.Name, "HqqmQt6JwVM69f");
                Assert.AreEqual(data.Module, "ekHtZ");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            ReportScriptTypeEnum v = new ReportScriptTypeEnum();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.ID = 49;
                v.Name = "HqqmQt6JwVM69f";
                v.Module = "ekHtZ";
                context.Set<ReportScriptTypeEnum>().Add(v);
                context.SaveChanges();
            }

            ReportScriptTypeEnumVM vm = _controller.Wtm.CreateVM<ReportScriptTypeEnumVM>();
            var oldID = v.ID;
            v = new ReportScriptTypeEnum();
            v.ID = oldID;
       		
            v.Name = "1fx3K2W";
            v.Module = "QmXj";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.Name", "");
            vm.FC.Add("Entity.Module", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportScriptTypeEnum>().Find(v.ID);
 				
                Assert.AreEqual(data.Name, "1fx3K2W");
                Assert.AreEqual(data.Module, "QmXj");
            }

        }

		[TestMethod]
        public void GetTest()
        {
            ReportScriptTypeEnum v = new ReportScriptTypeEnum();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.ID = 49;
                v.Name = "HqqmQt6JwVM69f";
                v.Module = "ekHtZ";
                context.Set<ReportScriptTypeEnum>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            ReportScriptTypeEnum v1 = new ReportScriptTypeEnum();
            ReportScriptTypeEnum v2 = new ReportScriptTypeEnum();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.ID = 49;
                v1.Name = "HqqmQt6JwVM69f";
                v1.Module = "ekHtZ";
                v2.ID = 7;
                v2.Name = "1fx3K2W";
                v2.Module = "QmXj";
                context.Set<ReportScriptTypeEnum>().Add(v1);
                context.Set<ReportScriptTypeEnum>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<ReportScriptTypeEnum>().Find(v1.ID);
                var data2 = context.Set<ReportScriptTypeEnum>().Find(v2.ID);
                Assert.AreEqual(data1, null);
            Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] {});
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }


    }
}
