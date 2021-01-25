using PowerDama.Business.DataGovernance;
using PowerDama.Core.Base;
using PowerDama.Repository.DataGovernance;
using PowerDama.Types.DataGovernance;
using System.Collections.Generic;

namespace PowerDama.Management.DataGovernance
{
    /// <summary>
    /// Term Logical Layer
    /// </summary>
    public class TermManager
    {
        private readonly ITermRepository _termRepository;

        /// <summary>
        /// 
        /// </summary>
        public TermManager()
        {
            _termRepository = new TermRepository();
        }

        /// <summary>
        /// Kavram Listesini getirir
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<Term>> GetTerms(Term request)
        {
            return _termRepository.Get(request);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Term> AddTerm(Term request)
        {
            return _termRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Term> UpdateTerm(Term request)
        {
            return _termRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<Term> RemoveTerm(Term request)
        {
            return _termRepository.Remove(request);
        }
    }
}
