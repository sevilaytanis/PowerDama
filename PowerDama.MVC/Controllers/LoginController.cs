using Microsoft.AspNetCore.Mvc;

namespace PowerDama.MVC.Controllers
{
    public class LoginController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        public LoginController()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("giris")]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]        
        public IActionResult Index(string username, string password)
        {
            return RedirectToAction("Index","Login");
        }
    }
}