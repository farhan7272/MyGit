using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace ExploreCalifornia
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<FormattingService>();
            services.AddTransient<FeatureToggle>(x => new FeatureToggle
            {
                EnableDevelopersException = configuration.GetValue<bool>("FeaturesToggles:EnableDevelopersException")
            });

            services.AddDbContext<BlogDataContext>(options => {
                var connectionString = configuration.GetConnectionString("BlogDbConnection");
                options.UseSqlServer(connectionString);
            });
            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,FeatureToggle featureToggle)
        {
            app.UseExceptionHandler("/error.html");
            if (featureToggle.EnableDevelopersException)
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.StartsWith("/invalid"))
                {
                    throw new Exception("ERROR");
                }
                await next();
            });

            app.UseMvc(routes => {
                routes.MapRoute("Default",
                    "{controller=Home}/{action=Index}/{id?}"
                );
            });
            app.UseFileServer();

        }
    }
}
