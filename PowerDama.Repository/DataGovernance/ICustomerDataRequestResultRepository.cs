using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    public interface ICustomerDataRequestResultRepository : IRepository<CustomerDataRequestResult, CustomerDataRequestResult>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<String>> GetSearchScript(CustomerDataRequestSearchScriptParameters request);
    }
}
