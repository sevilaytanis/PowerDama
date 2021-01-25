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
    public class TransferAbroadManager
    {
        private readonly ITransferAbroadRepository _transferAbroadRepository;

        /// <summary>
        /// 
        /// </summary>
        public TransferAbroadManager()
        {
            _transferAbroadRepository = new TransferAbroadRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TransferAbroad> AddTransferAbroad(TransferAbroad request)
        {
            return _transferAbroadRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<TransferAbroad>> GetTransferAbroads(TransferAbroad request)
        {
            return _transferAbroadRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TransferAbroad> UpdateTransferAbroad(TransferAbroad request)
        {
            return _transferAbroadRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TransferAbroad> RemoveTransferAbroad(TransferAbroad request)
        {
            return _transferAbroadRepository.Remove(request);
        }
    }
}
