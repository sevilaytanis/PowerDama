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
    public class MeasuresTakenManager
    {
        private readonly IMeasuresTakenRepository _measuresTakenRepository;

        /// <summary>
        /// 
        /// </summary>
        public MeasuresTakenManager()
        {
            _measuresTakenRepository = new MeasuresTakenRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<MeasuresTaken> AddMeasuresTaken(MeasuresTaken request)
        {
            return _measuresTakenRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<MeasuresTaken>> GetMeasuresTakens(MeasuresTaken request)
        {
            return _measuresTakenRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<MeasuresTaken> UpdateMeasuresTaken(MeasuresTaken request)
        {
            return _measuresTakenRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<MeasuresTaken> RemoveMeasuresTaken(MeasuresTaken request)
        {
            return _measuresTakenRepository.Remove(request);
        }
    }
}
