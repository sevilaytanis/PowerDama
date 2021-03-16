using PowerDama.Business.DataGovernance;
using PowerDama.Repository.DataGovernance;
using System;
using System.Collections.Generic;
using System.Text;

namespace PowerDama.Management.DataGovernance
{
    public class SQLScriptGenerationManager
    {
        private readonly ISQLScriptGenerationRepository _sqlScriptGenerationRepository;
        private readonly IParameterRepository _parameterRepository;

        /// <summary>
        /// 
        /// </summary>
        public SQLScriptGenerationManager()
        {
            _sqlScriptGenerationRepository = new SQLScriptGenerationRepository();
            _parameterRepository = new ParameterRepository();
        }
    }
}
