using PowerDama.Business.KVKK;
using PowerDama.Core.Base;
using PowerDama.Repository.KVKK;
using PowerDama.Types.KVKK;
using System.Collections.Generic;

namespace PowerDama.Management.KVKK
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerAgreementManager
    {
        private readonly ICustomerAgreementRepository _customerAgreementRepository;

        /// <summary>
        /// 
        /// </summary>
        public CustomerAgreementManager()
        {
            _customerAgreementRepository = new CustomerAgreementRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerAgreement> AddCustomerAgreement(CustomerAgreement request)
        {
            return _customerAgreementRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<CustomerAgreement>> AGetCustomerAgreements(CustomerAgreement request)
        {
            return _customerAgreementRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerAgreement> UpdateCustomerAgreement(CustomerAgreement request)
        {
            return _customerAgreementRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<CustomerAgreement> RemoveCustomerAgreement(CustomerAgreement request)
        {
            return _customerAgreementRepository.Remove(request);
        }
    }
}
