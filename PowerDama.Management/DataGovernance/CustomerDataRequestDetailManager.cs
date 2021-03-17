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
    public class CustomerDataRequestDetailManager
    {
        private readonly ICustomerDataRequestDetailRepository _customerDataRequestDetailRepository;

        /// <summary>
        /// 
        /// </summary>
        public CustomerDataRequestDetailManager()
        {
            _customerDataRequestDetailRepository = new CustomerDataRequestDetailRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<CustomerDataRequestDetail>> GetCustomerDataRequestDetails(CustomerDataRequestDetail request)
        {
            return _customerDataRequestDetailRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerDataRequestDetail> AddCustomerDataRequestDetail(CustomerDataRequestDetail request)
        {
            return _customerDataRequestDetailRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerDataRequestDetail> UpdateCustomerDataRequestDetail(CustomerDataRequestDetail request)
        {
            return _customerDataRequestDetailRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerDataRequestDetail> RemoveCustomerDataRequestDetail(CustomerDataRequestDetail request)
        {
            return _customerDataRequestDetailRepository.Remove(request);
        }
    }
}
