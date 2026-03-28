using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using em_wtm.Controllers;
using em_wtm.ViewModel.Report.ReportScriptParamVMs;
using em_wtm.Model._Business.Report;
using em_wtm.DataAccess;


namespace em_wtm.Test
{
    [TestClass]
    public class ReportScriptParamApiTest
    {
        private ReportScriptParamController _controller;
        private string _seed;

        public ReportScriptParamApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<ReportScriptParamController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new ReportScriptParamSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content)==false);
        }

        [TestMethod]
        public void CreateTest()
        {
            ReportScriptParamVM vm = _controller.Wtm.CreateVM<ReportScriptParamVM>();
            ReportScriptParam v = new ReportScriptParam();
            
            v.ID = 37;
            v.ReportID = AddReportMain();
            v.ScriptID = AddReportScript();
            v.Name = "U8V6UabrXAmhu";
            v.Field = "SV9tDDxW8Uiv";
            v.Description = "wJoMDpnlW5";
            v.ParamOperatorID = AddReportParamOperatorEnum();
            v.DefaultValue = "EFSPQnx2lu3OM";
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportScriptParam>().Find(v.ID);
                
                Assert.AreEqual(data.ID, 37);
                Assert.AreEqual(data.Name, "U8V6UabrXAmhu");
                Assert.AreEqual(data.Field, "SV9tDDxW8Uiv");
                Assert.AreEqual(data.Description, "wJoMDpnlW5");
                Assert.AreEqual(data.DefaultValue, "EFSPQnx2lu3OM");
            }
        }

        [TestMethod]
        public void EditTest()
        {
            ReportScriptParam v = new ReportScriptParam();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.ID = 37;
                v.ReportID = AddReportMain();
                v.ScriptID = AddReportScript();
                v.Name = "U8V6UabrXAmhu";
                v.Field = "SV9tDDxW8Uiv";
                v.Description = "wJoMDpnlW5";
                v.ParamOperatorID = AddReportParamOperatorEnum();
                v.DefaultValue = "EFSPQnx2lu3OM";
                context.Set<ReportScriptParam>().Add(v);
                context.SaveChanges();
            }

            ReportScriptParamVM vm = _controller.Wtm.CreateVM<ReportScriptParamVM>();
            var oldID = v.ID;
            v = new ReportScriptParam();
            v.ID = oldID;
       		
            v.Name = "Oylrd";
            v.Field = "JGzCXjFz1zP2N";
            v.Description = "8TgEsCwwjWo";
            v.DefaultValue = "zhVn";
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.ReportId", "");
            vm.FC.Add("Entity.ScriptID", "");
            vm.FC.Add("Entity.Name", "");
            vm.FC.Add("Entity.Field", "");
            vm.FC.Add("Entity.Description", "");
            vm.FC.Add("Entity.ParamOperatorID", "");
            vm.FC.Add("Entity.DefaultValue", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportScriptParam>().Find(v.ID);
 				
                Assert.AreEqual(data.Name, "Oylrd");
                Assert.AreEqual(data.Field, "JGzCXjFz1zP2N");
                Assert.AreEqual(data.Description, "8TgEsCwwjWo");
                Assert.AreEqual(data.DefaultValue, "zhVn");
            }

        }

		[TestMethod]
        public void GetTest()
        {
            ReportScriptParam v = new ReportScriptParam();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.ID = 37;
                v.ReportID = AddReportMain();
                v.ScriptID = AddReportScript();
                v.Name = "U8V6UabrXAmhu";
                v.Field = "SV9tDDxW8Uiv";
                v.Description = "wJoMDpnlW5";
                v.ParamOperatorID = AddReportParamOperatorEnum();
                v.DefaultValue = "EFSPQnx2lu3OM";
                context.Set<ReportScriptParam>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            ReportScriptParam v1 = new ReportScriptParam();
            ReportScriptParam v2 = new ReportScriptParam();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.ID = 37;
                v1.ReportID = AddReportMain();
                v1.ScriptID = AddReportScript();
                v1.Name = "U8V6UabrXAmhu";
                v1.Field = "SV9tDDxW8Uiv";
                v1.Description = "wJoMDpnlW5";
                v1.ParamOperatorID = AddReportParamOperatorEnum();
                v1.DefaultValue = "EFSPQnx2lu3OM";
                v2.ID = 82;
                v2.ReportID = v1.ReportID; 
                v2.ScriptID = v1.ScriptID; 
                v2.Name = "Oylrd";
                v2.Field = "JGzCXjFz1zP2N";
                v2.Description = "8TgEsCwwjWo";
                v2.ParamOperatorID = v1.ParamOperatorID; 
                v2.DefaultValue = "zhVn";
                context.Set<ReportScriptParam>().Add(v1);
                context.Set<ReportScriptParam>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<ReportScriptParam>().Find(v1.ID);
                var data2 = context.Set<ReportScriptParam>().Find(v2.ID);
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

                v.ID = 70;
                v.Description = "yKtadm3RYK2";
                v.Name = "IGRhw6QZ";
                v.Title = "3yJQsUc";
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

                v.ID = 55;
                v.Name = "RbAj8LZfSYfNeGYQ";
                v.Module = "dsCRWbrJii8AIz7hqs";
                context.Set<ReportScriptTypeEnum>().Add(v);
                context.SaveChanges();
                }
                catch{}
            }
            return v.ID;
        }

        private Int32 AddReportScript()
        {
            ReportScript v = new ReportScript();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try{

                v.ID = 51;
                v.ReportID = AddReportMain();
                v.Script = "HUTvoSY5nKgvhZ";
                v.ScriptTypeId = AddReportScriptTypeEnum();
                v.ScriptOrder = 61;
                context.Set<ReportScript>().Add(v);
                context.SaveChanges();
                }
                catch{}
            }
            return v.ID;
        }

        private Int32 AddReportParamOperatorEnum()
        {
            ReportParamOperatorEnum v = new ReportParamOperatorEnum();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try{

                v.ID = 17;
                v.Operator = "lsq0";
                v.OperatorTips = "xyZVEciYk5sj";
                context.Set<ReportParamOperatorEnum>().Add(v);
                context.SaveChanges();
                }
                catch{}
            }
            return v.ID;
        }


    }
}
