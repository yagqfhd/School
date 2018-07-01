using GanGao.Component.Data;
using GanGao.School.Core.Models.UserPermissions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Web;

namespace GanGao.School.Core.Data.UserPermissions.Configurations
{
    /// <summary>
    /// 权限表配置类
    /// </summary>
    public class PermissionConfiguration : EntityTypeConfiguration<SysPermission>, IEntityMapper
    {
        public PermissionConfiguration()
        {
            // 表名次定义
            this.ToTable("Sys_Permissions");
            //主键定义
            this.HasKey(m => m.Id);
            //索引定义
            this.HasIndex(m => m.Name);    
            //属性定义
            this.Property(m => m.Id).HasMaxLength(64);
            this.Property(m => m.Name).HasMaxLength(16);            
            this.Property(m => m.Description).HasMaxLength(128);
            
            //// 排除字段定义
            //this.Ignore(m => m.AddDate).Ignore(m => m.IsDeleted).Ignore(m => m.Timestamp);
            ////关系映射
            //this.HasMany(m => m.Departments).WithOptional().HasForeignKey(k => k.PermissionId);
        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }

    /// <summary>
    /// 权限部门表配置类
    /// </summary>
    public class PermissionDepartmentConfiguration : EntityTypeConfiguration<PermissionDepartment>, IEntityMapper
    {
        public PermissionDepartmentConfiguration()
        {
            // 表名次定义
            this.ToTable("Sys_PermissionDepartments");

            //主键定义
            this.HasKey((PermissionDepartment m) => new { PermissionId = m.PermissionId, DepartmentId = m.DepartmentId });
            //索引定义
            this.HasIndex(m => m.PermissionId);
            this.HasIndex(m => m.DepartmentId);
            //属性定义
            this.Property(m => m.PermissionId).HasMaxLength(64);
            this.Property(m => m.DepartmentId).HasMaxLength(64);
            //关系映射
            this.HasMany(m => m.Roles).WithOptional().HasForeignKey(k => new { PermissionId = k.PermissionId, DepartmentId = k.DepartmentId });

        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }

    /// <summary>
    /// 权限部门角色表配置类
    /// </summary>
    public class PermissionDepartmentRoleConfiguration : EntityTypeConfiguration<PermissionDepartmentRole>, IEntityMapper
    {
        public PermissionDepartmentRoleConfiguration()
        {
            // 表名次定义
            this.ToTable("Sys_PermissionDepartmentRoles");

            //主键定义
            this.HasKey((PermissionDepartmentRole m) => new { PermissionId = m.PermissionId, DepartmentId = m.DepartmentId ,RoleId = m.RoleId});
            //索引定义
            this.HasIndex(m => m.PermissionId);
            this.HasIndex(m => m.DepartmentId);
            //属性定义
            this.Property(m => m.PermissionId).HasMaxLength(64);
            this.Property(m => m.DepartmentId).HasMaxLength(64);
            
            //关系映射
            this.HasRequired(m => m.Role).WithMany().HasForeignKey(k=>k.RoleId);

        }

        public void RegistTo(ConfigurationRegistrar configurations)
        {
            configurations.Add(this);
        }
    }
}