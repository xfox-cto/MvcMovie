﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /helloworld/
        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /helloworld/welcome
        public string Welcome()
        {
            return "This is Welcom action method...";
        }
    }
}
