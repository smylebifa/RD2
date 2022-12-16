using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RD.Data;
using RD.Services;

namespace RD
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
            //services.AddHttpsRedirection(options =>
            //{
            //    options.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
            //    options.HttpsPort = 44395;
            //});

            //services.AddHsts(options =>
            //{
            //    options.Preload = true;
            //    options.IncludeSubDomains = true;
            //    options.MaxAge = TimeSpan.FromDays(60);
            //});

            services.AddControllersWithViews();

            //string mySqlConnectionStr = Configuration.GetConnectionString("Default");

            //services.AddDbContext<TestDbContext>(options => options.UseMySql(mySqlConnectionStr,
            //    ServerVersion.AutoDetect(mySqlConnectionStr)));

            //services.AddDbContext<TestDbContext>(options => options.UseNpgsql(Configuration.GetConnectionString("Default")));

            //services.AddTransient<IUsersService, UsersService>();
            //services.AddTransient<IThemesService, ThemesService>();
            //services.AddTransient<ITRLsService, TRLsService>();
            //services.AddTransient<IStagesService, StagesService>();

            //services.AddTransient<AuthenticationService>();

            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(options => options.LoginPath = "/login");

            services.AddTransient<UsersService>();
            services.AddTransient<ThemesService>();
            services.AddTransient<StagesService>();
            services.AddTransient<TRLsService>();
            services.AddTransient<AuthenticationService>();
            
            services.AddTransient<CustomersService>();

            services.AddTransient<CounterpartiesService>();
            services.AddTransient<AnnualFinancingsService>();
           
            services.AddTransient<RIAsService>();
           
            services.AddTransient<FilesService>();
           
            services.AddTransient<ProductsService>();

            services.AddTransient<ScientificDocsService>();

            services.AddTransient<ContractsService>();


            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => options.LoginPath = "/login");
                

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePages();

            //app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
