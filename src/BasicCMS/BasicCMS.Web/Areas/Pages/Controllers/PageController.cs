using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCMS.Lib.Pages;
using BasicCMS.Web.Areas.Pages.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicCMS.Web.Areas.Pages.Controllers
{
    [Area("Pages")]
    public class PageController : Controller
    {
        private readonly IPageProvider PageProvider;

        public PageController(IPageProvider pageProvider)
        {
            PageProvider = pageProvider;
        }

        public async Task<IActionResult> PageAsync(string url)
        {
            var page = await PageProvider.GetAsync(url);
            if (page == null) return NotFound();

            var vm = new PageViewModel() { Page = page };

            return View(vm);
        }
    }
}