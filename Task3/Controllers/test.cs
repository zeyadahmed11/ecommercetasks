﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task3.Controllers
{
    public class testController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

      
       public IActionResult Contact()
        {

            return View();
        }

        public IActionResult blog()
        {

            return View();

        }
    }
}
