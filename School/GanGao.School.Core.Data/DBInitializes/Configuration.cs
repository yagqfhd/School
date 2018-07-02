using GanGao.Component.Data;
using GanGao.School.Core.Models.UserPermissions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;


namespace GanGao.School.Core.Data.DBInitializes
{
    internal sealed class Configuration : DbMigrationsConfiguration<EFDbContext>
    {
        public Configuration()
        {
            
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EFDbContext context)
        {
            //if(context.Database.Exists())
            //{
            //    context.Database.CompatibleWithModel(false);
            //    return;
            //}
            //Console.WriteLine("context.Database.CreateIfNotExists() return = {0}", context.Database.CreateIfNotExists());
            //if (context.Database.CreateIfNotExists())
            //{
                
            //    return;
            //}

            #region ///// 创建初始化角色
                List<SysRole> roles = new List<SysRole>
            {
                new SysRole {Name="管理员" },
                new SysRole {Name = "校长" },
                new SysRole {Name = "副校长" },
                new SysRole {Name="主任" },
                new SysRole {Name="副主任" },
                new SysRole {Name="教师" },
                new SysRole {Name="教工" }
            };
            DbSet<SysRole> roleSet = context.Set<SysRole>();
            roleSet.AddOrUpdate(m => new { m.Name }, roles.ToArray());
            context.SaveChanges();
            #endregion
            #region //////创建初始化部门
            List<SysDepartment> departments = new List<SysDepartment>
            {
                new SysDepartment {Name="甘高" },
                new SysDepartment {Name ="办公室" },
                new SysDepartment {Name="政教处" },
                new SysDepartment {Name="德育处" },
                new SysDepartment {Name="总务处" },
            };
            DbSet<SysDepartment> departmentSet = context.Set<SysDepartment>();
            departmentSet.AddOrUpdate(m => new { m.Name }, departments.ToArray());
            context.SaveChanges();
            #endregion
            #region //// 创建初始化用户
            List<SysUser> users = new List<SysUser>
            {
                new SysUser{ Name = "admin", Description = "系统管理",Nick="管理员"},
                new SysUser{ Name = "fhd", Description = "系统设计者",Nick="无所谓"},
                new SysUser{ Name = "yagqfhd", Description = "教师",Nick="付东"},
                new SysUser{ Name = "schooladmin", Description = "学校管理员", Nick = "管理者"},                
            };
            DbSet<SysUser> userSet = context.Set<SysUser>();
            userSet.AddOrUpdate(m=>new { m.Name }, users.ToArray());
            context.SaveChanges();
            #endregion
        }
    }
}