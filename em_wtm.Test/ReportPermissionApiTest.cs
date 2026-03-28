using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WalkingTec.Mvvm.Core;
using em_wtm.Controllers;
using em_wtm.ViewModel.Report.ReportPermissionVMs;
using em_wtm.Model._Business.Report;
using em_wtm.DataAccess;


namespace em_wtm.Test
{
    [TestClass]
    public class ReportPermissionApiTest
    {
        private ReportPermissionController _controller;
        private string _seed;

        public ReportPermissionApiTest()
        {
            _seed = Guid.NewGuid().ToString();
            _controller = MockController.CreateApi<ReportPermissionController>(new DataContext(_seed, DBTypeEnum.Memory), "user");
        }

        [TestMethod]
        public void SearchTest()
        {
            ContentResult rv = _controller.Search(new ReportPermissionSearcher()) as ContentResult;
            Assert.IsTrue(string.IsNullOrEmpty(rv.Content)==false);
        }

        [TestMethod]
        public void CreateTest()
        {
            ReportPermissionVM vm = _controller.Wtm.CreateVM<ReportPermissionVM>();
            ReportPermission v = new ReportPermission();
            
            v.ID = 87;
            v.ReportId = AddReportMain();
            v.UserId = AddFrameworkUser();
            vm.Entity = v;
            var rv = _controller.Add(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportPermission>().Find(v.ID);
                
                Assert.AreEqual(data.ID, 87);
            }
        }

        [TestMethod]
        public void EditTest()
        {
            ReportPermission v = new ReportPermission();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
       			
                v.ID = 87;
                v.ReportId = AddReportMain();
                v.UserId = AddFrameworkUser();
                context.Set<ReportPermission>().Add(v);
                context.SaveChanges();
            }

            ReportPermissionVM vm = _controller.Wtm.CreateVM<ReportPermissionVM>();
            var oldID = v.ID;
            v = new ReportPermission();
            v.ID = oldID;
       		
            vm.Entity = v;
            vm.FC = new Dictionary<string, object>();
			
            vm.FC.Add("Entity.ID", "");
            vm.FC.Add("Entity.ReportId", "");
            vm.FC.Add("Entity.UserId", "");
            var rv = _controller.Edit(vm);
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data = context.Set<ReportPermission>().Find(v.ID);
 				
            }

        }

		[TestMethod]
        public void GetTest()
        {
            ReportPermission v = new ReportPermission();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
        		
                v.ID = 87;
                v.ReportId = AddReportMain();
                v.UserId = AddFrameworkUser();
                context.Set<ReportPermission>().Add(v);
                context.SaveChanges();
            }
            var rv = _controller.Get(v.ID.ToString());
            Assert.IsNotNull(rv);
        }

        [TestMethod]
        public void BatchDeleteTest()
        {
            ReportPermission v1 = new ReportPermission();
            ReportPermission v2 = new ReportPermission();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
				
                v1.ID = 87;
                v1.ReportId = AddReportMain();
                v1.UserId = AddFrameworkUser();
                v2.ID = 55;
                v2.ReportId = v1.ReportId; 
                v2.UserId = v1.UserId; 
                context.Set<ReportPermission>().Add(v1);
                context.Set<ReportPermission>().Add(v2);
                context.SaveChanges();
            }

            var rv = _controller.BatchDelete(new string[] { v1.ID.ToString(), v2.ID.ToString() });
            Assert.IsInstanceOfType(rv, typeof(OkObjectResult));

            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                var data1 = context.Set<ReportPermission>().Find(v1.ID);
                var data2 = context.Set<ReportPermission>().Find(v2.ID);
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

                v.ID = 89;
                v.Description = "lJbJ";
                v.Name = "j";
                v.Title = "UArYFuM60gPKuk2z";
                context.Set<ReportMain>().Add(v);
                context.SaveChanges();
                }
                catch{}
            }
            return v.ID;
        }

        private Guid AddFileAttachment()
        {
            FileAttachment v = new FileAttachment();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try{

                v.FileName = "6hqSXr5";
                v.FileExt = "gMBdBk";
                v.Path = "T8kcKFwBPS";
                v.Length = 70;
                v.UploadTime = DateTime.Parse("2024-02-24 17:22:40");
                v.SaveMode = "IXHAInhp";
                v.ExtraInfo = "elh";
                v.HandlerInfo = "dnY";
                context.Set<FileAttachment>().Add(v);
                context.SaveChanges();
                }
                catch{}
            }
            return v.ID;
        }

        private Guid AddFrameworkUser()
        {
            FrameworkUser v = new FrameworkUser();
            using (var context = new DataContext(_seed, DBTypeEnum.Memory))
            {
                try{

                v.Email = "QMoEjVzR5ruzZIiB3vyY7DEwCXWr0fgSj82x2lzaLu9AT";
                v.Gender = WalkingTec.Mvvm.Core.GenderEnum.Male;
                v.HomePhone = "o5M4Aqb";
                v.Address = "vYvOWPCaspqujOA461ciGShbD1zGEaWEa0h9M4pq0l70KfiddzPxjLTvMEVPwmNuOolCOeNJDAmJIvchOviqWZopmAFwmVw6PV2ZU3m1Ly65yx";
                v.ZipCode = "Wz54LEwd";
                v.CellPhone = "Yp9NgHq";
                v.ITCode = "SNCf0p6PTQSsjOgd8Oq3KekZdKfado7HIe";
                v.Password = "SG0EZfhvt9BEU1e3lR63p02x";
                v.Name = "Buze";
                v.IsValid = false;
                v.PhotoId = AddFileAttachment();
                context.Set<FrameworkUser>().Add(v);
                context.SaveChanges();
                }
                catch{}
            }
            return v.ID;
        }


    }
}
