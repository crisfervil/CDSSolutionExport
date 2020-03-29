using System;
using Microsoft.Xrm.Sdk;

namespace CDSSolutionExport
{
    class SolutionManager
    {

        private IOrganizationService _service;
        public SolutionManager(IOrganizationService service){
            _service = service;
        }

        public void TestConnection(){
            
        }

        public void GetSolComponents(string solutionName)
        {
            
        }
    }
}