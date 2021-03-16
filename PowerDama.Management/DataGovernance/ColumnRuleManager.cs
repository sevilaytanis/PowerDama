using PowerDama.Business.DataGovernance;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Management.DataGovernance
{
    public class ColumnRuleManager
    {
        private readonly IColumnRuleRepository _columnRuleRepository;

        /// <summary>
        /// 
        /// </summary>
        public ColumnRuleManager()
        {
            _columnRuleRepository = new ColumnRuleRepository();
        }

        /// <summary>
        /// Select ColumnRules
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<ColumnRule>> GetColumnRules(ColumnRule request)
        {
            return _columnRuleRepository.Get(request);
        }

        /// <summary>
        /// Insert ColumnRule to DB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<ColumnRule> AddColumnRule(ColumnRule request)
        {
            return _columnRuleRepository.Add(request);
        }

        /// <summary>
        /// Update ColumnRule in DB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<ColumnRule> UpdateColumnRule(ColumnRule request)
        {
            return _columnRuleRepository.Update(request);
        }

        /// <summary>
        /// Delete ColumnRule from DB
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<ColumnRule> RemoveColumnRule(ColumnRule request)
        {
            return _columnRuleRepository.Remove(request);
        }

        /// <summary>
        /// Select ColumnRule By TermId
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BaseResponse<ColumnRule> GetColumnRuleByTermId(int id)
        {
            return _columnRuleRepository.GetColumnRuleByTermId(id);
        }
    }
}
