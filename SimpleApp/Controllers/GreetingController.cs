using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using static SimpleApp.Models.GreetingModels;

namespace SimpleApp.Controllers
{
    public class GreetingController : Controller
    {
        Greeting myGreeting = new Greeting();

        

        public IActionResult Index(int id)
        {
           
            ViewData["Greeting"] = myGreeting.GetGreeting(id);

            
            return View();
        }
    }
}

