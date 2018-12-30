using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace BasicCMS.Web.Areas.Pages
{
    public static class AreaConfig
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
