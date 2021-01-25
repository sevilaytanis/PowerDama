using PowerDama.Business.KVKK;
using PowerDama.Core.Base;
using PowerDama.Repository.KVKK;
using PowerDama.Types.KVKK;
using System.Collections.Generic;

namespace PowerDama.Management.KVKK
{
    public class DataCategoryManager
    {
        private readonly IDataCategoryRepository _dataCategoryRepository;

        /// <summary>
        /// 
        /// </summary>
        public DataCategoryManager()
        {
            _dataCategoryRepository = new DataCategoryRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DataCategory> AddDataCategory(DataCategory request)
        {
            return _dataCategoryRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<DataCategory>> GetDataCategories(DataCategory request)
        {
            return _dataCategoryRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DataCategory> UpdateDataCategory(DataCategory request)
        {
            return _dataCategoryRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<DataCategory> RemoveDataCategory(DataCategory request)
        {
            return _dataCategoryRepository.Remove(request);
        }
    }
}
