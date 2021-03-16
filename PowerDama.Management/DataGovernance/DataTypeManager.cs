using PowerDama.Business.DataGovernance;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerDama.Management.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public class DataTypeManager
    {
        private readonly IDataTypeRepository _dataTypeRepository;

        /// <summary>
        /// 
        /// </summary>
        public DataTypeManager()
        {
            _dataTypeRepository = new DataTypeRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<DataType>> GetDataTypes(DataType request)
        {
            return _dataTypeRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DataType> AddDataType(DataType request)
        {
            return _dataTypeRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DataType> GetDataTypeByKey(DataType request)
        {
            return _dataTypeRepository.GetByKey(request);
        }
    }
}
