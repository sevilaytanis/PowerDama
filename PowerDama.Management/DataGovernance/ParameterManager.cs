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
    public class ParameterManager
    {
        private readonly IParameterRepository _parameterRepository;

        /// <summary>
        /// 
        /// </summary>
        public ParameterManager()
        {
            _parameterRepository = new ParameterRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<VParameter>> GetParameters(VParameter request)
        {
            return _parameterRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramType"></param>
        /// <param name="paramCode"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        public BaseResponse<List<DTGParameter>> GetDTGParameters(string paramType, string paramCode, byte? languageId)
        {
            return _parameterRepository.GetDTGParameter(paramType, paramCode, languageId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DTGParameter> AddDTGParameters(DTGParameter request)
        {
            return _parameterRepository.AddDTGParameter(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="oldParamType"></param>
        /// <param name="oldParamCode"></param>
        /// <param name="oldLanguageId"></param>
        /// <returns></returns>
        public BaseResponse<DTGParameter> UpdateDTGParameters(DTGParameter request, string oldParamType, string oldParamCode, byte oldLanguageId)
        {
            return _parameterRepository.UpdateDTGParameter(request, oldParamType, oldParamCode, oldLanguageId);
        }
    }
}
