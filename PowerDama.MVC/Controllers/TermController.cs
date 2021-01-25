using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PowerDama.MVC.Controllers
{
    public class TermController : Controller
    {
        [Route("terms")]
        public IActionResult Index()
        {
            return View();
        }
    }
}