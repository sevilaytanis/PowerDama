using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PowerDama.Management.DataGovernance;
using PowerDama.MVC.Models;
using PowerDama.Types.DataGovernance;

namespace PowerDama.MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var _termManager = new TermManager();
            var items = _termManager.GetTerms(new Term());
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
