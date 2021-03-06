﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.Composition;
using GanGao.School.Core.Data.UserPermissions.Repositories;
using GanGao.School.Core.Models.UserPermissions;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.IO;
using GanGao.School.Core.Data.DBInitializes;
using GanGao.School.Core.Data.Infrastructure;

namespace School.Test.TestCore.Data
{
    
    [TestClass]
    public class UnitCoreData
    {

        private static CompositionContainer _container;
        [Import]
        protected IUserRepository userStore { get; set; }

        private void Compose()
        {
            //初始化MEF组合容器
            AggregateCatalog catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog(Directory.GetCurrentDirectory()));
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            _container = new CompositionContainer(catalog);

            //var asembly = Assembly.Load("GanGao.School.Core.Data");//.GetExecutingAssembly();
            //var catalog = new AggregateCatalog();  //new AssemblyCatalog(asembly);
            //catalog.Catalogs.Add(new AssemblyCatalog(asembly));
            //asembly = Assembly.Load("GanGao.School.Core");
            //catalog.Catalogs.Add(new AssemblyCatalog(asembly));
            //asembly = Assembly.Load("GanGao.School.Core");
            //catalog.Catalogs.Add(new AssemblyCatalog(asembly));
            //catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            //CompositionContainer container = new CompositionContainer(catalog);
            //var tmp = container.GetExport<IUserRepository>();
            //tmp.Value.
            _container.ComposeParts(this);
        }

        public UnitCoreData()
        {
          //  DatabaseInitializer.Initialize();
        }

        [TestMethod]
        public void TestCreateDataBase()
        {
            this.Compose();
            DatabaseInitializer.Initialize();
            if (userStore == null)
            {
                Console.WriteLine("Import Error");
                userStore = new UserRepository();
            }
            Console.WriteLine("UserStore Init OK!");
            userStore.Insert(new SysUser { Name = "admin" },true);
        }

        [TestMethod]
        public void TestUserRepository()
        {

        }
    }
}
