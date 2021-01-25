using PowerDama.Business.KVKK;
using PowerDama.Core.Base;
using PowerDama.Repository.KVKK;
using PowerDama.Types.KVKK;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerDama.Management.KVKK
{
    /// <summary>
    /// 
    /// </summary>
    public class KvkkInventoryManager
    {
        private readonly IKvkkinventoryRepository _kvkkInventoryRepository;

        /// <summary>
        /// 
        /// </summary>
        public KvkkInventoryManager()
        {
            _kvkkInventoryRepository = new KvkkInventoryRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Kvkkinventory> AddKvkkInventory(Kvkkinventory request)
        {
            return _kvkkInventoryRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<Kvkkinventory>> GetKvkkInventory(Kvkkinventory request)
        {
            return _kvkkInventoryRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Kvkkinventory> UpdateKvkkInventory(Kvkkinventory request)
        {
            return _kvkkInventoryRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Kvkkinventory> RemoveKvkkInventory(Kvkkinventory request)
        {
            return _kvkkInventoryRepository.Remove(request);
        }
    }
}
