using PowerDama.Core.Base;
using PowerDama.Repository.Base;
using PowerDama.Types.DataGovernance;
using System;
using System.Collections.Generic;

namespace PowerDama.Repository.DataGovernance
{
    /// <summary>
    /// Term Template
    /// </summary>
    public interface ITermRepository : IRepository<Term, Term>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<Term> GetByKey(int termId, byte languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<Term>> GetByColumns(Term request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<Term>> GetWithDataMaskTypeByColumns(Term request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<Term>> GetByNameAndType(Term request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<List<Term>> GetByColumnName(string columnName, byte languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<Term> GetFromTableKeyColumn(int termId, byte languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<List<Term>> GetFromTableReferenceColumn(int termId, byte languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="columnName"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<List<Term>> GetTableTermByReferenceColumnName(string columnName, byte languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moduleId"></param>
        /// <returns></returns>
        BaseResponse<String> GetTermCodeByModuleId(int moduleId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<Int32> UpdateTermDataMask(TermDataMask request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <returns></returns>
        BaseResponse<List<TermTableRelation>> GetTermTableRelationByTermId(int termId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <param name="languageId"></param>
        /// <returns></returns>
        BaseResponse<List<TermDataMask>> GetTermDataMaskByTermId(int termId, byte languageId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromTermId"></param>
        /// <param name="toTermId"></param>
        /// <returns></returns>
        BaseResponse<Int32> TermTransfer(int fromTermId, int toTermId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        BaseResponse<Int32> AddTermDataMask(TermDataMask request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="termId"></param>
        /// <param name="sensitivityId"></param>
        /// <returns></returns>
        BaseResponse<Int32> UpdateTermBySensitivity(int termId, byte sensitivityId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        BaseResponse<Int32> RecommendedTextCountByUserName(string userName);
    }
}
