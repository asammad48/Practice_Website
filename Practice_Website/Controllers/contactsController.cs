﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Practice_Website.Controllers
{
    public class contactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}