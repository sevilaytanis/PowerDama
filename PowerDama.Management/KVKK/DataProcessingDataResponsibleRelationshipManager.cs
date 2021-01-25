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
    public class DataProcessingDataResponsibleRelationshipManager
    {
        private readonly IDataProcessingDataResponsibleRelationshipRepository _dataProcessingDataResponsibleRelationshipRepository;

        /// <summary>
        /// 
        /// </summary>
        public DataProcessingDataResponsibleRelationshipManager()
        {
            _dataProcessingDataResponsibleRelationshipRepository = new DataProcessingDataResponsibleRelationshipRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DataProcessingDataResponsibleRelationship> Add(DataProcessingDataResponsibleRelationship request)
        {
            return _dataProcessingDataResponsibleRelationshipRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<DataProcessingDataResponsibleRelationship>> Get(DataProcessingDataResponsibleRelationship request)
        {
            return _dataProcessingDataResponsibleRelationshipRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DataProcessingDataResponsibleRelationship> Update(DataProcessingDataResponsibleRelationship request)
        {
            return _dataProcessingDataResponsibleRelationshipRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DataProcessingDataResponsibleRelationship> Remove(DataProcessingDataResponsibleRelationship request)
        {
            return _dataProcessingDataResponsibleRelationshipRepository.Remove(request);
        }
    }
}
