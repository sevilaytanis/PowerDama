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
    public class PackageLocationManager
    {
        private readonly IPackageLocationRepository _packageLocationRepository;

        /// <summary>
        /// 
        /// </summary>
        public PackageLocationManager()
        {
            _packageLocationRepository = new PackageLocationRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<SchemaItem>> GetSchemas(PackageLocation request)
        {
            return _packageLocationRepository.GetSchemaList(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<PackageLocation>> GetByColumns(PackageLocation request)
        {
            return _packageLocationRepository.GetByColumns(request);
        }
    }
}
