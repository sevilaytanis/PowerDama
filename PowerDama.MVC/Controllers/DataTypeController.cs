using Microsoft.AspNetCore.Mvc;
using PowerDama.Management.DataGovernance;
using PowerDama.MVC.Models.DataGovernance;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.MVC.Controllers
{
    public class DataTypeController : Controller
    {
        private DataTypeManager _dataTypeManager;

        /// <summary>
        /// 
        /// </summary>
        public DataTypeController()
        {
            _dataTypeManager = new DataTypeManager();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("datatypes")]
        public IActionResult Index()
        {
            var response = _dataTypeManager.GetDataTypes(new DataType());
            if (!response.Success)
            {

            }
            var typeList = new List<DataTypeVM>();
            foreach (var item in response.Value)
            {
                var dataType = new DataTypeVM()
                {
                    DataTypeId = item.DataTypeId,
                    Name = item.Name,
                    NameEn = item.NameEn,
                    Value = item.Value
                };
                typeList.Add(dataType);
            }
            return View(typeList);
        }
    }
}