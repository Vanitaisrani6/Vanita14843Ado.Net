using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using MVCDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{
    public class RegistrationController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult RegistrationForm()
        {
            return View(new Registration());
        }

        
        public IActionResult DisplayRegistrationData(Registration registration)
        {

            return View();
        }


    }
}
