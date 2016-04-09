using YZMIS.Data.Mapping;
using YZMIS.Objects;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace YZMIS.Data.Core
{
    public class Context : DbContext
    {
        #region Administration

        protected DbSet<Role> Roles { get; set; }
        protected DbSet<Account> Accounts { get; set; }
        protected DbSet<Permission> Permissions { get; set; }
        protected DbSet<RolePermission> RolePermissions { get; set; }

        #endregion

        #region System

        protected DbSet<AuditLog> AuditLogs { get; set; }

        #endregion

        static Context()
        {
            ObjectMapper.MapObjects();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Properties<DateTime>().Configure(config => config.HasColumnType("datetime2"));
            modelBuilder.Entity<Permission>().Property(model => model.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
