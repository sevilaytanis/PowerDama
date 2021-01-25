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
    public class LegalBasisManager
    {
        private readonly ILegalBasisRepository _legalBasisRepository;

        /// <summary>
        /// 
        /// </summary>
        public LegalBasisManager()
        {
            _legalBasisRepository = new LegalBasisRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<LegalBasis> AddLegalBasis(LegalBasis request)
        {
            return _legalBasisRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<LegalBasis>> GetLegalBasises(LegalBasis request)
        {
            return _legalBasisRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<LegalBasis> UpdateLegalBasis(LegalBasis request)
        {
            return _legalBasisRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<LegalBasis> RemoveLegalBasis(LegalBasis request)
        {
            return _legalBasisRepository.Remove(request);
        }
    }
}
