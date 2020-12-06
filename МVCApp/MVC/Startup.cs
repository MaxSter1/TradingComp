using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ManagerMVC.Domain;
using ManagerMVC.Domain.Repositories.Abstract;
using ManagerMVC.Domain.Repositories.EntityFramework;
using ManagerMVC.Service;

namespace ManagerMVC
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {

            Configuration.Bind("Project", new Config());

           
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();

           
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

           
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

          
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "ManagerMVCAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

           
       
            services.AddAuthorization(x =>
            {
                x.AddPolicy("ManagerArea", policy => { policy.RequireRole("manager"); });
            });


            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new ManagerAreaAuthorization("Manager", "ManagerArea"));
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
          

          
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            
            app.UseStaticFiles();

            //подключаем систему маршрутизации
            app.UseRouting();

            //подключаем аутентификацию и авторизацию
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            //регистриуруем нужные нам маршруты (ендпоинты)
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("manager", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
