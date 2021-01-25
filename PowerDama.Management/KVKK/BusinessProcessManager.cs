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
    public class BusinessProcessManager
    {
        private readonly IBusinessProcessRepository _businessProcessRepository;

        /// <summary>
        /// 
        /// </summary>
        public BusinessProcessManager()
        {
            _businessProcessRepository = new BusinessProcessRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<BusinessProcess> AddBusinessProcess(BusinessProcess request)
        {
            return _businessProcessRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<BusinessProcess>> GetBusinessProcesses(BusinessProcess request)
        {
            return _businessProcessRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<BusinessProcess> UpdateBusinessProcess(BusinessProcess request)
        {
            return _businessProcessRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<BusinessProcess> RemoveBusinessProcess(BusinessProcess request)
        {
            return _businessProcessRepository.Remove(request);
        }
    }
}
