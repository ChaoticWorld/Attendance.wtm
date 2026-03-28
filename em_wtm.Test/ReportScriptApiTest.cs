using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using em_wtm.Controllers;
using em_wtm.ViewModel.Report.ReportScriptVMs;
using em_wtm.Model._Business.Report;
using em_wtm.DataAccess;


namespace em_wtm.Test
{
    [TestClass]
    public class ReportScriptApiTest
    {
        private ReportScriptController _controller;
        private string _seed;

        public ReportScriptApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<ReportScriptController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new ReportScriptSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content)==false);
        }

        [TestMethod]
        public void CreateTest()
        {
            ReportScriptVM vm = _controller.Wtm.CreateVM<ReportScriptVM>();
            ReportScript v = new ReportScript();
            
            v.ID = 62;
            v.ReportID = AddReportMain();
            v.Script = "P7yuIA2p3lLCZXX";
            v.ScriptTypeId = AddReportScriptTypeEnum();
            v.ScriptOrder = 28;
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportScript>().Find(v.ID);
                
                Assert.AreEqual(data.ID, 62);
                Assert.AreEqual(data.Script, "P7yuIA2p3lLCZXX");
                Assert.AreEqual(data.ScriptOrder, 28);
            }
        }

        [TestMethod]
        public void EditTest()
        {
            ReportScript v = new ReportScript();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.ID = 62;
                v.ReportID = AddReportMain();
                v.Script = "P7yuIA2p3lLCZXX";
                v.ScriptTypeId = AddReportScriptTypeEnum();
                v.ScriptOrder = 28;
                context.Set<ReportScript>().Add(v);
                context.SaveChanges();
            }

            ReportScriptVM vm = _controller.Wtm.CreateVM<ReportScriptVM>();
            var oldID = v.ID;
            v = new ReportScript();
            v.ID = oldID;
       		
            v.Script = "eI7dH5foy";
            v.ScriptOrder = 49;
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.ReportId", "");
            vm.FC.Add("Entity.Script", "");
            vm.FC.Add("Entity.ScriptTypeId", "");
            vm.FC.Add("Entity.ScriptOrder", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportScript>().Find(v.ID);
 				
                Assert.AreEqual(data.Script, "eI7dH5foy");
                Assert.AreEqual(data.ScriptOrder, 49);
            }

        }

		[TestMethod]
        public void GetTest()
        {
            ReportScript v = new ReportScript();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.ID = 62;
                v.ReportID = AddReportMain();
                v.Script = "P7yuIA2p3lLCZXX";
                v.ScriptTypeId = AddReportScriptTypeEnum();
                v.ScriptOrder = 28;
                context.Set<ReportScript>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            ReportScript v1 = new ReportScript();
            ReportScript v2 = new ReportScript();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.ID = 62;
                v1.ReportID = AddReportMain();
                v1.Script = "P7yuIA2p3lLCZXX";
                v1.ScriptTypeId = AddReportScriptTypeEnum();
                v1.ScriptOrder = 28;
                v2.ID = 38;
                v2.ReportID = v1.ReportID; 
                v2.Script = "eI7dH5foy";
                v2.ScriptTypeId = v1.ScriptTypeId; 
                v2.ScriptOrder = 49;
                context.Set<ReportScript>().Add(v1);
                context.Set<ReportScript>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<ReportScript>().Find(v1.ID);
                var data2 = context.Set<ReportScript>().Find(v2.ID);
                Assert.AreEqual(data1, null);
            Assert.AreEqual(data2, null);
            }

            rv = _controller.BatchDelete(new string[] {});
            Assert.IsInstanceOfType(rv, typeof(OkResult));

        }

        private Int32 AddReportMain()
        {
            ReportMain v = new ReportMain();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try{

                v.ID = 25;
                v.Description = "8iFivRHt2CIIPY";
                v.Name = "waKWy5N";
                v.Title = "Ch5RS7f";
                context.Set<ReportMain>().Add(v);
                context.SaveChanges();
                }
                catch{}
            }
            return v.ID;
        }

        private Int32 AddReportScriptTypeEnum()
        {
            ReportScriptTypeEnum v = new ReportScriptTypeEnum();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try{

                v.ID = 13;
                v.Name = "7eQ0wh3";
                v.Module = "qUoR3L";
                context.Set<ReportScriptTypeEnum>().Add(v);
                context.SaveChanges();
                }
                catch{}
            }
            return v.ID;
        }


    }
}
