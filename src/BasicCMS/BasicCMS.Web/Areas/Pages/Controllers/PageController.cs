using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCMS.Lib.Pages;
using Microsoft.AspNetCore.Mvc;

namespace BasicCMS.Web.Areas.Pages.Controllers
{
    [Area("Pages")]
    public class PageController : Controller
    {
        public async Task<IActionResult> PageAsync(string url)
        {
            var page = await PageResolver.GetPageAsync(url);
            if (page == null) return NotFound();

            ViewBag.Url = url;
            ViewBag.Page = page;

            return View();
        }
    }
}