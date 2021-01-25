using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public interface IColumnRuleRepository : IRepository<ColumnRule, ColumnRule>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <returns></returns>
        BaseResponse<ColumnRule> GetColumnRuleByTermId(int termId);
    }
}
