using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPackageLocationRepository : IRepository<PackageLocation, PackageLocation>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<PackageLocation>> GetByColumns(PackageLocation request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<SchemaItem>> GetSchemaList(PackageLocation request);
    }
}
