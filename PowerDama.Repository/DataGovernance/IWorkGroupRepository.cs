using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    public interface IWorkGroupRepository : IRepository<WorkGroup, WorkGroup>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        BaseResponse<List<WorkGroup>> SelectWorkGroupListOfUser(string username);
    }
}
