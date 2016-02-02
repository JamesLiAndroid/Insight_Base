﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Insight.WS.Base.Common.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BaseEntities : DbContext
    {
        public BaseEntities()
            : base("name=BaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<SYS_Module> SYS_Module { get; set; }
        public virtual DbSet<SYS_ModuleAction> SYS_ModuleAction { get; set; }
        public virtual DbSet<SYS_ModuleGroup> SYS_ModuleGroup { get; set; }
        public virtual DbSet<SYS_ModuleParam> SYS_ModuleParam { get; set; }
        public virtual DbSet<SYS_Organization> SYS_Organization { get; set; }
        public virtual DbSet<SYS_OrgMember> SYS_OrgMember { get; set; }
        public virtual DbSet<SYS_OrgMerger> SYS_OrgMerger { get; set; }
        public virtual DbSet<SYS_Role> SYS_Role { get; set; }
        public virtual DbSet<SYS_Role_Title> SYS_Role_Title { get; set; }
        public virtual DbSet<SYS_Role_User> SYS_Role_User { get; set; }
        public virtual DbSet<SYS_Role_UserGroup> SYS_Role_UserGroup { get; set; }
        public virtual DbSet<SYS_RolePerm_Action> SYS_RolePerm_Action { get; set; }
        public virtual DbSet<SYS_RolePerm_Data> SYS_RolePerm_Data { get; set; }
        public virtual DbSet<SYS_RolePerm_DataAbs> SYS_RolePerm_DataAbs { get; set; }
        public virtual DbSet<SYS_User> SYS_User { get; set; }
        public virtual DbSet<SYS_UserGroup> SYS_UserGroup { get; set; }
        public virtual DbSet<SYS_UserGroupMember> SYS_UserGroupMember { get; set; }
        public virtual DbSet<SYS_Allot_Record> SYS_Allot_Record { get; set; }
        public virtual DbSet<SYS_Code_Allot> SYS_Code_Allot { get; set; }
        public virtual DbSet<SYS_Code_Record> SYS_Code_Record { get; set; }
        public virtual DbSet<SYS_Code_Scheme> SYS_Code_Scheme { get; set; }
    
        [DbFunction("BaseEntities", "Authority")]
        public virtual IQueryable<Authority> Authority(Nullable<System.Guid> userId, Nullable<System.Guid> deptId, Nullable<System.Guid> actionId)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(System.Guid));
    
            var deptIdParameter = deptId.HasValue ?
                new ObjectParameter("DeptId", deptId) :
                new ObjectParameter("DeptId", typeof(System.Guid));
    
            var actionIdParameter = actionId.HasValue ?
                new ObjectParameter("ActionId", actionId) :
                new ObjectParameter("ActionId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Authority>("[BaseEntities].[Authority](@UserId, @DeptId, @ActionId)", userIdParameter, deptIdParameter, actionIdParameter);
        }
    }
}
