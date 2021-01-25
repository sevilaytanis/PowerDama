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
    public class ExplicitConsentManager
    {
        private readonly IExplicitConsentRepository _explicitConsentRepository;

        /// <summary>
        /// 
        /// </summary>
        public ExplicitConsentManager()
        {
            _explicitConsentRepository = new ExplicitConsentRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<ExplicitConsent> AddExplicitConsent(ExplicitConsent request)
        {
            return _explicitConsentRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<ExplicitConsent>> GetExplicitConsents(ExplicitConsent request)
        {
            return _explicitConsentRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<ExplicitConsent> UpdateExplicitConsent(ExplicitConsent request)
        {
            return _explicitConsentRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<ExplicitConsent> RemoveExplicitConsent(ExplicitConsent request)
        {
            return _explicitConsentRepository.Remove(request);
        }
    }
}
