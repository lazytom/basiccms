using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicCMS.Web.Areas.Pages
{
    public class AreaConfig
    {
        public static void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );

                routes.MapRoute(
                    name: "pages",
                    template: "{*url}",
                    defaults: new { area = "Pages", controller = "Page", action = "Page" }
                );
            });
        }
    }
}
