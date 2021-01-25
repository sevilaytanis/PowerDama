using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITermRuleRepository : IRepository<TermRule, TermRule>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <param name="templateType"></param>
        /// <param name="alertStatus"></param>
        /// <returns></returns>
        BaseResponse<List<TermRule>> SelectTermRuleByColumns(int? termId, byte? templateType, byte? alertStatus);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<Int32> UpdateBaseTermRule(TermRule request);
    }
}
