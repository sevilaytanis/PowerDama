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
    public class AccessibilityManager
    {
        private readonly IAccessibilityRepository _accessibilityRepository;

        /// <summary>
        /// 
        /// </summary>
        public AccessibilityManager()
        {
            _accessibilityRepository = new AccessibilityRepository();
        }

        /// <summary>
        /// Select Accessibilities
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<Accessibility>> GetAccessibilities(Accessibility request)
        {
            return _accessibilityRepository.Get(request);
        }

        /// <summary>
        /// Insert Accessibility to DB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Accessibility> AddAccessibility(Accessibility request)
        {
            return _accessibilityRepository.Add(request);
        }

        /// <summary>
        /// Update Accessibility in DB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Accessibility> UpdateAccessibility(Accessibility request)
        {
            return _accessibilityRepository.Update(request);
        }

        /// <summary>
        /// Delete Accessibility from DB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Accessibility> RemoveAccessibility(Accessibility request)
        {
            return _accessibilityRepository.Remove(request);
        }
    }
}
