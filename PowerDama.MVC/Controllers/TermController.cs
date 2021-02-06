using Microsoft.AspNetCore.Mvc;

namespace PowerDama.MVC.Controllers
{
    public class TermController : Controller
    {
        [Route("termsdark")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("termlist")]
        public IActionResult Term()
        {
            return View();
        }

        [Route("terms")]
        public IActionResult TermFilter()
        {
            return View();
        }
    }
}