using PowerDama.Repository.DataGovernance;
using PowerDama.Business.DataGovernance;
using System.Collections.Generic;
using PowerDama.Core.Base;
using PowerDama.Types.DataGovernance;

namespace PowerDama.Management.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class IntegrityManager
    {
        private readonly IIntegrityRepository _integrityRepository;

        /// <summary>
        /// 
        /// </summary>
        public IntegrityManager()
        {
            _integrityRepository = new IntegrityRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<Integrity>> GetIntegrity(Integrity request)
        {
            return _integrityRepository.Get(request);
        }
    }
}
