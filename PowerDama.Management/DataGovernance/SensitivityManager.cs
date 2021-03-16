using PowerDama.Business.DataGovernance;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerDama.Management.DataGovernance
{
    public class SensitivityManager
    {
        private readonly ISensitivityRepository _sensitivityRepository;

        /// <summary>
        /// 
        /// </summary>
        public SensitivityManager()
        {
            _sensitivityRepository = new SensitivityRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<Sensitivity>> GetSensitivities(Sensitivity request)
        {
            return _sensitivityRepository.Get(request);
        }
    }
}
