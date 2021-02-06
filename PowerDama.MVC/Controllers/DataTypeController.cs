using Microsoft.AspNetCore.Mvc;

namespace PowerDama.MVC.Controllers
{
    public class DataTypeController : Controller
    {
        [Route("datatypes")]
        public IActionResult Index()
        {
            return View();
        }
    }
}