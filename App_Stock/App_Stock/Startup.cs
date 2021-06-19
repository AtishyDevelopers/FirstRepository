using App_Stock.Controllers;
using AppStock.Persistence;
using AppStock.Persistence.Repositries;
using AppStock.Services;
using AppStock.Services.Services;
using APPSTOCK.Persistence.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace App_Stock
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
            services.AddControllers();
            services.AddSignalR();
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ModuleRepository, ModuleRepository>();
            services.AddScoped<ModuleService, ModuleService>();
            services.AddScoped<RoleRepository, RoleRepository>();
            services.AddScoped<RoleService, RoleService>();
            services.AddScoped<GroupRepository, GroupRepository>();
            services.AddScoped<GroupService, GroupService>();
            services.AddScoped<MenusRepository, MenusRepository>();
            services.AddScoped<MenusService, MenusService>();
            services.AddScoped<FormsRepository, FormsRepository>();
            services.AddScoped<FormsService, FormsService>();
            services.AddScoped<RoleFormsMapRepository, RoleFormsMapRepository>();
            services.AddScoped<RoleFormsMapService,RoleFormsMapService>();
            services.AddScoped<MenuFormMapRepository, MenuFormMapRepository>();
            services.AddScoped<MenuFormMapService, MenuFormMapService>();

            services.AddScoped<FormPathDrpRepository, FormPathDrpRepository>();
            services.AddScoped<FormPathDrpService, FormPathDrpService>();

            services.AddScoped<RoleMenuMapRepository, RoleMenuMapRepository>();
            services.AddScoped<RoleMenuMapService, RoleMenuMapService>();
            services.AddScoped<RoleModuleMapRepository, RoleModuleMapRepository>();
            services.AddScoped<RoleModuleMapService, RoleModuleMapService>();
            services.AddScoped<UserReportController, UserReportController>();
            services.AddScoped<UserReportRepository, UserReportRepository>();
            services.AddScoped<UserReportService, UserReportService>();

            services.AddScoped<NotificationFeedRepository, NotificationFeedRepository>();
            services.AddScoped<NotificationFeedService, NotificationFeedService>();

            services.AddScoped<NotificationRulesController, NotificationRulesController>();
            services.AddScoped<NotificationRulesRepository, NotificationRulesRepository>();
            services.AddScoped<NotificationRulesService, NotificationRulesService>();

            services.AddScoped<RulesNotificationController, RulesNotificationController>();
            services.AddScoped<RulesNotificationRepository, RulesNotificationRepository>();
            services.AddScoped<RulesNotificationService, RulesNotificationService>();

            services.AddScoped<SendNotificationController, SendNotificationController>();
            services.AddScoped<SendMailRepository, SendMailRepository>();
            services.AddScoped<SendMailService, SendMailService>();

            services.AddScoped<UserMasterController, UserMasterController>();
            services.AddScoped<UserMasterRepository, UserMasterRepository>();
            services.AddScoped<UserMasterService, UserMasterService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
