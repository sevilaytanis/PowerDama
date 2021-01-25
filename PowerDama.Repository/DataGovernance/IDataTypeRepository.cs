using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDataTypeRepository : IRepository<DataType, DataType>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<DataType> GetByKey(DataType request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTypeLanguageId"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<List<DataType>> GetTemplateDataType(byte dataTypeLanguageId, byte? languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<Int32> InsertDataTypeMatch(DataType request);
    }
}
