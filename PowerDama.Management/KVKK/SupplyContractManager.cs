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
    public class SupplyContractManager
    {
        private readonly ISupplyContractRepository _supplyContractRepository;

        /// <summary>
        /// 
        /// </summary>
        public SupplyContractManager()
        {
            _supplyContractRepository = new SupplyContractRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<SupplyContract> AddSupplyContract(SupplyContract request)
        {
            return _supplyContractRepository.Add(request); 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<SupplyContract>> GetSupplyContracts(SupplyContract request)
        {
            return _supplyContractRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<SupplyContract> UpdateSupplyContract(SupplyContract request)
        {
            return _supplyContractRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<SupplyContract> RemoveSupplyContract(SupplyContract request)
        {
            return _supplyContractRepository.Remove(request);
        }
    }
}
