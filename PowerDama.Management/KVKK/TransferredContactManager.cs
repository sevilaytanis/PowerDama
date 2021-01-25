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
    public class TransferredContactManager
    {
        private readonly ITransferredContactGroupRepository _transferredContactGroupRepository;

        /// <summary>
        /// 
        /// </summary>
        public TransferredContactManager()
        {
            _transferredContactGroupRepository = new TransferredContactGroupRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TransferredContactGroup> AddTransferredContactGroup(TransferredContactGroup request)
        {
            return _transferredContactGroupRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<TransferredContactGroup>> GetTransferredContactGroups(TransferredContactGroup request)
        {
            return _transferredContactGroupRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TransferredContactGroup> UpdateTransferredContactGroup(TransferredContactGroup request)
        {
            return _transferredContactGroupRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<TransferredContactGroup> RemoveTransferredContactGroup(TransferredContactGroup request)
        {
            return _transferredContactGroupRepository.Remove(request);
        }
    }
}
