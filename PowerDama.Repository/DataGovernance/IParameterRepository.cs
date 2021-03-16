using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public interface IParameterRepository : IRepository<VParameter, VParameter>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paramType"></param>
        /// <param name="paramCode"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<List<DTGParameter>> GetDTGParameter(string paramType, string paramCode, byte? languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="oldParamType"></param>
        /// <param name="oldParamCode"></param>
        /// <param name="oldLanguageId"></param>
        /// <returns></returns>
        BaseResponse<DTGParameter> UpdateDTGParameter(DTGParameter request, string oldParamType, string oldParamCode, byte oldLanguageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<DTGParameter> AddDTGParameter(DTGParameter request);
    }
}
