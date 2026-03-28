using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using em_wtm.Controllers;
using em_wtm.ViewModel.Report.ReportParamOperatorEnumVMs;
using em_wtm.Model._Business.Report;
using em_wtm.DataAccess;


namespace em_wtm.Test
{
    [TestClass]
    public class ReportParamOperatorEnumApiTest
    {
        private ReportParamOperatorEnumController _controller;
        private string _seed;

        public ReportParamOperatorEnumApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<ReportParamOperatorEnumController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new ReportParamOperatorEnumSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content)==false);
        }

        [TestMethod]
        public void CreateTest()
        {
            ReportParamOperatorEnumVM vm = _controller.Wtm.CreateVM<ReportParamOperatorEnumVM>();
            ReportParamOperatorEnum v = new ReportParamOperatorEnum();
            
            v.ID = 56;
            v.Operator = "bOls1kfxbtcbP5cO";
            v.OperatorTips = "9t7K";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportParamOperatorEnum>().Find(v.ID);
                
                Assert.AreEqual(data.ID, 56);
                Assert.AreEqual(data.Operator, "bOls1kfxbtcbP5cO");
                Assert.AreEqual(data.OperatorTips, "9t7K");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            ReportParamOperatorEnum v = new ReportParamOperatorEnum();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.ID = 56;
                v.Operator = "bOls1kfxbtcbP5cO";
                v.OperatorTips = "9t7K";
                context.Set<ReportParamOperatorEnum>().Add(v);
                context.SaveChanges();
            }

            ReportParamOperatorEnumVM vm = _controller.Wtm.CreateVM<ReportParamOperatorEnumVM>();
            var oldID = v.ID;
            v = new ReportParamOperatorEnum();
            v.ID = oldID;
       		
            v.Operator = "9u68zUPXlNRCiG";
            v.OperatorTips = "dqCoBQ";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.Id", "");
            vm.FC.Add("Entity.Operator", "");
            vm.FC.Add("Entity.OperatorTips", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportParamOperatorEnum>().Find(v.ID);
 				
                Assert.AreEqual(data.Operator, "9u68zUPXlNRCiG");
                Assert.AreEqual(data.OperatorTips, "dqCoBQ");
            }

        }

		[TestMethod]
        public void GetTest()
        {
            ReportParamOperatorEnum v = new ReportParamOperatorEnum();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.ID = 56;
                v.Operator = "bOls1kfxbtcbP5cO";
                v.OperatorTips = "9t7K";
                context.Set<ReportParamOperatorEnum>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            ReportParamOperatorEnum v1 = new ReportParamOperatorEnum();
            ReportParamOperatorEnum v2 = new ReportParamOperatorEnum();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.ID = 56;
                v1.Operator = "bOls1kfxbtcbP5cO";
                v1.OperatorTips = "9t7K";
                v2.ID = 19;
                v2.Operator = "9u68zUPXlNRCiG";
                v2.OperatorTips = "dqCoBQ";
                context.Set<ReportParamOperatorEnum>().Add(v1);
                context.Set<ReportParamOperatorEnum>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<ReportParamOperatorEnum>().Find(v1.ID);
                var data2 = context.Set<ReportParamOperatorEnum>().Find(v2.ID);
                Assert.AreEqual(data1, null);
            Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] {});
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }


    }
}
