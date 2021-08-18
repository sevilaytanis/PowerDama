using Microsoft.AspNetCore.Mvc;
using PowerDama.Management.DataGovernance;
using PowerDama.MVC.Models.DataGovernance;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.MVC.Controllers
{
    public class TermController : Controller
    {
        private TermManager _termManager;

        /// <summary>
        /// 
        /// </summary>
        public TermController()
        {
            _termManager = new TermManager();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("termsdark")]
        public IActionResult Index()
        {
            var response = _termManager.GetTerms(new Term());
            if (!response.Success)
            {
                return RedirectToAction("Index","Home");
            }
            var termList = new List<TermVM>();

            foreach (var item in response.Value)
            {
                var term = new TermVM()
                {
                    TermId = item.TermId,
                    TermCode = item.TermCode,
                    TermType = item.TermType,
                    Name = item.Name,
                    NameEn = item.NameEn,
                    Description = item.Description,
                    UserName = item.UserName,
                    Type = item.Type,
                    SystemDate = item.SystemDate
                };
                termList.Add(term);
            }

            return View(termList);
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