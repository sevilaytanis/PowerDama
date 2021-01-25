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
    public class RetentionTimeManager
    {
        private readonly IRetentionTimeRepository _retentionTimeRepository;

        /// <summary>
        /// 
        /// </summary>
        public RetentionTimeManager()
        {
            _retentionTimeRepository = new RetentionTimeRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<RetentionTime> AddRetentionTime(RetentionTime request)
        {
            return _retentionTimeRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<RetentionTime>> GetRetentionTimes(RetentionTime request)
        {
            return _retentionTimeRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<RetentionTime> UpdateRetentionTime(RetentionTime request)
        {
            return _retentionTimeRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<RetentionTime> RemoveRetentionTime(RetentionTime request)
        {
            return _retentionTimeRepository.Remove(request);
        }
    }
}
