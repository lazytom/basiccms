using System;
using BasicCMS.Lib.Pages;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BasicCMS.Admin.Areas.Admin
{
    public static class AreaConfig
    {
        public static void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "admin",
                    template: "_admin/{controller=Home}/{action=Index}/{id?}",
                    defaults: new { area = "Admin" }
                );
            });

        }

    }
}
