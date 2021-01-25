using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDataTypeLanguageRepository : IRepository<DataTypeLanguage, DataTypeLanguage>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<List<DataTypeLanguage>> GetDataTypeLanguage(byte? languageId);
    }
}
