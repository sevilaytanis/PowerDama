using System.Collections.Generic;
using PowerDama.Repository.KVKK;
using PowerDama.Business.KVKK;
using PowerDama.Types.KVKK;
using PowerDama.Core.Base;

namespace PowerDama.Management
{
    /// <summary>
    /// Activity Logical Layer
    /// </summary>
    public class ActivityManager
    {
        private readonly IActivityRepository _activityRepository;

        /// <summary>
        /// 
        /// </summary>
        public ActivityManager()
        {
            _activityRepository = new ActivityRepository();
        }

        /// <summary>
        /// Select Activities
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<Activity>> GetActivities(Activity request)
        {
            return _activityRepository.Get(request);
        }

        /// <summary>
        /// Insert Activity to DB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Activity> AddActivity(Activity request)
        {
            return _activityRepository.Add(request);
        }

        /// <summary>
        /// Update Activity in DB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Activity> UpdateActivity(Activity request)
        {
            return _activityRepository.Update(request);
        }

        /// <summary>
        /// Delete Activity from DB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Activity> RemoveActivity(Activity request)
        {
            return _activityRepository.Remove(request);
        }
    }
}
