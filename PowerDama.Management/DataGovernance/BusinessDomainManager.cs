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
    public class BusinessDomainManager
    {
        private readonly IBusinessDomainRepository _businessDomainRepository;

        /// <summary>
        /// 
        /// </summary>
        public BusinessDomainManager()
        {
            _businessDomainRepository = new BusinessDomainRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<BusinessDomain>> GetBusinessDomains(BusinessDomain request)
        {
            return _businessDomainRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<BusinessDomain> AddBusinessDomain(BusinessDomain request)
        {
            return _businessDomainRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<BusinessDomain> UpdateBusinessDomain(BusinessDomain request)
        {
            return _businessDomainRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<BusinessDomain> RemoveBusinessDomain(BusinessDomain request)
        {
            return _businessDomainRepository.Remove(request);
        }
    }
}
