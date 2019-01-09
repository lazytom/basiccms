using System;
using BasicCMS.Lib.Pages;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BasicCMS.Web.Areas.Pages
{
    public static class AreaConfig
    {
        public static void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name: "areas",
                //    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                //);

                routes.MapRoute(
                    name: "identity",
                    template: "Identity/{controller=Home}/{action=Index}/{id?}",
                    defaults: new { area = "Identity" }
                );

                routes.MapRoute(
                    name: "pages",
                    template: "{*url}",
                    defaults: new { area = "Pages", controller = "Page", action = "PageAsync" }
                );
            });
        }

        internal static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            //services.AddConfiguration();  // enable Configuration Services

            var config = new LocalDiskPageProviderSettings();
            configuration.Bind("LocalDiskPageProviderSettings", config);      //  <--- This
            services.AddSingleton(config);

            services.AddScoped<IPageProvider, LocalDiskPageProvider>();
        }
    }
}
