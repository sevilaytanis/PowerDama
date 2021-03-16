using PowerDama.Business.DataGovernance;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Management.DataGovernance
{
    public class DataTypeLanguageManager
    {
        private readonly IDataTypeLanguageRepository _dataTypeLanguageRepository;

        /// <summary>
        /// 
        /// </summary>
        public DataTypeLanguageManager()
        {
            _dataTypeLanguageRepository = new DataTypeLanguageRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="languageId"></param>
        /// <returns></returns>
        public BaseResponse<List<DataTypeLanguage>> GetDataTypeLanguage(byte? languageId)
        {
            return _dataTypeLanguageRepository.GetDataTypeLanguage(languageId);
        }
    }
}
