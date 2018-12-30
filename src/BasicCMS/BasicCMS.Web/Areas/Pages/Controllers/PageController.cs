using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasicCMS.Web.Areas.Pages.Controllers
{
    [Area("Pages")]
    public class PageController : Controller
    {
        public IActionResult Page(string url)
        {
            ViewBag.Url = url;
            return View();
        }
    }
}