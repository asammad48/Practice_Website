using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Practice_Website.Controllers
{
    public class galleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}