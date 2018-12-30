﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasicCMSWeb.Areas.Pages.Controllers
{
    [Area("Pages")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}