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
    public class ProcessingPurposeManager
    {
        private readonly IProcessingPurposeRepository _processingPurposeRepository;

        /// <summary>
        /// 
        /// </summary>
        public ProcessingPurposeManager()
        {
            _processingPurposeRepository = new ProcessingPurposeRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<ProcessingPurpose> AddProcessingPurpose(ProcessingPurpose request)
        {
            return _processingPurposeRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<ProcessingPurpose>> GetProcessingPurposes(ProcessingPurpose request)
        {
            return _processingPurposeRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<ProcessingPurpose> UpdateProcessingPurpose(ProcessingPurpose request)
        {
            return _processingPurposeRepository.Update(request);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<ProcessingPurpose> RemoveProcessingPurpose(ProcessingPurpose request)
        {
            return _processingPurposeRepository.Remove(request);
        }
    }
}
