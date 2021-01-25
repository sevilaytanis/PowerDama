using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PowerDama.MVC.Controllers
{
    public class LoginController : Controller
    {
        [Route("giris")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]        
        public IActionResult Index(string username, string password)
        {
            return RedirectToAction("Index","Login");
        }
    }
}