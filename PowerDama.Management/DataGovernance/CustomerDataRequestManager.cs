using PowerDama.Business.DataGovernance;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Management.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerDataRequestManager
    {
        private readonly ICustomerDataRequestRepository _customerDataRequestRepository;

        /// <summary>
        /// 
        /// </summary>
        public CustomerDataRequestManager()
        {
            _customerDataRequestRepository = new CustomerDataRequestRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<CustomerDataRequest>> GetCustomerDataRequests(CustomerDataRequest request)
        {
            return _customerDataRequestRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerDataRequest> AddCustomerDataRequest(CustomerDataRequest request)
        {
            return _customerDataRequestRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerDataRequest> UpdateCustomerDataRequest(CustomerDataRequest request)
        {
            return _customerDataRequestRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerDataRequest> RemoveCustomerDataRequest(CustomerDataRequest request)
        {
            return _customerDataRequestRepository.Remove(request);
        }
    }
}
