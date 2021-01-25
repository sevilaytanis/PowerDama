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
    public class ClarificationManager
    {
        private readonly IClarificationRepository _clarificationRepository;

        /// <summary>
        /// 
        /// </summary>
        public ClarificationManager()
        {
            _clarificationRepository = new ClarificationRepository(); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Clarification> AddClarification(Clarification request)
        {
            return _clarificationRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<Clarification>> GetClarifications(Clarification request)
        {
            return _clarificationRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Clarification> UpdateClarification(Clarification request)
        {
            return _clarificationRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Clarification> RemoveClarification(Clarification request)
        {
            return _clarificationRepository.Remove(request);
        }
    }
}
