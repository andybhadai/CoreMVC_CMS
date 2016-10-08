using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TechnoBergCMS.Services;
using Microsoft.Extensions.Configuration;
using TechnoBergCMS.Data;
using Microsoft.EntityFrameworkCore;

namespace TechnoBergCMS
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                .AddJsonFile($"appsettings.json{env.EnvironmentName}.json", optional:true);

            builder.AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            services.AddMvc();

            // Register the service, and define to use it as a singleton
            //services.AddSingleton<IBlogRepository, InMemoryBlogRepository>();

            services.AddScoped<IBlogRepository, DatabaseBlogRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            // Use static HTML, CSS and JavaScript files
            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();


            // On page load, the default route is the HomeController with its Index-method
            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                    name: "blog",
                    template: "{controller=Blog}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                    name: "product",
                    template: "{controller=Product}/{action=Index}/{id?}"
                );
            });
        }
    }
}
