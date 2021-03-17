using PowerDama.Business.DataGovernance;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;

namespace PowerDama.Management.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerDataRequestResultManager
    {
        private readonly ICustomerDataRequestResultRepository _customerDataRequestResultRepository;

        /// <summary>
        /// 
        /// </summary>
        public CustomerDataRequestResultManager()
        {
            _customerDataRequestResultRepository = new CustomerDataRequestResultRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="requests"></param>
        /// <returns></returns>
        public BaseResponse<List<String>> GetSearchScript(List<CustomerDataRequestSearchScriptParameters> requests)
        {
            var response = new BaseResponse<List<String>>();
            response.Value = new List<String>();

            foreach (var item in requests)
            {
                var result = _customerDataRequestResultRepository.GetSearchScript(item);
                if (!result.Success)
                {
                    response.ErrorMessage = result.ErrorMessage;
                    response.Success = result.Success;
                    return response;
                }

                if (result.Value == null || result.Value.Count == 0)
                    continue;
                foreach (var value in result.Value)
                    response.Value.Add(value);                
            }

            response.Success = true;
            return response;
        }
    }
}
