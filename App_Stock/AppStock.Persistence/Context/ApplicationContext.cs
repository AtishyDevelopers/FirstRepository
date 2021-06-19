
using AppStock.core.Models;
using APPSTOCK.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
namespace APPSTOCK.Persistence.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.SetCommandTimeout(TimeSpan.FromMinutes(4).Seconds);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<User>().HasNoKey();
            builder.Entity<Employees>().HasNoKey();
            builder.Entity<ModulesModel>().HasNoKey();
          
            builder.Entity<ResponseModel>().HasNoKey();
            builder.Entity<ResponseModelJSON>().HasNoKey();
            builder.Entity<RoleModel>().HasNoKey();
            builder.Entity<GroupModel>().HasNoKey();
            builder.Entity<MenusModel>().HasNoKey();
            builder.Entity<FormsModel>().HasNoKey();
            builder.Entity<RoleFormsMapModel>().HasNoKey();
            builder.Entity<MenuFormMapModel>().HasNoKey();
            builder.Entity<FormPathDrpModel>().HasNoKey();

            builder.Entity<RoleMenuMapModel>().HasNoKey();
            builder.Entity<RoleModuleMapModel>().HasNoKey();
            builder.Entity<UserReportModel>().HasNoKey();
            builder.Entity<NotificationFeedModel>().HasNoKey();
            builder.Entity<UsersMaster>().HasNoKey();
            builder.Entity<LoginModel>().HasNoKey();
              builder.Entity<UserDetailModel>().HasNoKey();
            builder.Entity<GroupModel>().HasNoKey();
          //  builder.Entity<DesignationMaster>().HasNoKey();
            builder.Entity<MenuFormMapModel>().HasNoKey();
            builder.Entity<NotificationRulesModel>().HasNoKey();
            builder.Entity<ProjectsModel>().HasNoKey();
            builder.Entity<NotificationActionsModel>().HasNoKey();
            builder.Entity<NotificationRecipientsModel>().HasNoKey();
            builder.Entity<NotificationChannelsModel>().HasNoKey();
            builder.Entity<NotificationSubActionsModel>().HasNoKey();
            builder.Entity<NotificationEntityTypeModel>().HasNoKey();
            builder.Entity<EmailConfig>().HasNoKey();
            builder.Entity<SendMailModel>().HasNoKey();
            builder.Entity<UserDetailModel>().HasNoKey();
            base.OnModelCreating(builder);

        }

          public DbSet<User> UserModel { get; set; }
        //public DbSet<UserModel> UsersModel { get; set; }
        //public DbSet<Employees> Employees { get; set; }
        public DbSet<ResponseModel> ResponseModel { get; set; }
        public DbSet<ResponseModelJSON> ResponseModelJSON { get; set; }
    
        public DbSet<ModulesModel> ModulesModel { get; set; }
        public DbSet<RoleModel> RoleModel { get; set; }
        public DbSet<GroupModel> GroupModel { get; set; }
        public DbSet<MenusModel> MenusModel { get; set; }
        public DbSet<FormsModel> FormsModel { get; set; }
        public DbSet<RoleFormsMapModel> RoleFormsMapModel { get; set; }
        public DbSet<FormPathDrpModel> FormPathDrpModel { get; set; }
        public DbSet<MenuFormMapModel> MenuFormMapModel { get; set; }
        public DbSet<NotificationFeedModel> NotificationFeedModel { get; set; }
        public DbSet<RoleModuleMapModel> RoleModuleMapModel
        {
            get; set;
        }
        public DbSet<UserReportModel> UserReportModel { get; set; }
        public DbSet<RoleMenuMapModel> RoleMenuMapModel { get; set; }


        public DbSet<DepartmentMaster> DepartmentMaster { get; set; }
       // public DbSet<DesignationMaster> DesignationMaster { get; set; }
        public DbSet<UsersMaster> UsersMaster { get; set; }
        public DbSet<LoginModel> LoginModel { get; set; }
        //  public DbSet<RoleFormMapModel> RoleFormMapModel { get; set; }
        // public DbSet<MenuFormMapModel> MenuFormMapModel { get; set; }
         public DbSet<UserDetailModel> UserDetailModel { get; set; }
        public DbSet<NotificationRulesModel> NotificationRulesModel { get; set; }
        public DbSet<EmailConfig> EmailConfig { get; set; }
    }
}
