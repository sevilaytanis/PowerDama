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
    public class RelatedPersonManager
    {
        private readonly IRelatedPersonRepository _relatedPersonRepository;

        /// <summary>
        /// 
        /// </summary>
        public RelatedPersonManager()
        {
            _relatedPersonRepository = new RelatedPersonRepository();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<RelatedPerson> AddRelatedPerson(RelatedPerson request)
        {
            return _relatedPersonRepository.Add(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<List<RelatedPerson>> GetRelatedPersons(RelatedPerson request)
        {
            return _relatedPersonRepository.Get(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<RelatedPerson> UpdateRelatedPerson(RelatedPerson request)
        {
            return _relatedPersonRepository.Update(request);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public BaseResponse<RelatedPerson> RemoveRelatedPerson(RelatedPerson request)
        {
            return _relatedPersonRepository.Remove(request);
        }
    }
}
