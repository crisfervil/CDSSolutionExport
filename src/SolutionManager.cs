using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

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
            var qry = new QueryByAttribute("solution"){
                ColumnSet = new ColumnSet("uniquename","friendlyname","description")
            } ;
            qry.Attributes.AddRange("uniquename");
            qry.Values.AddRange(solutionName);

            var result = _service.RetrieveMultiple(qry);
            if(result.TotalRecordCount==0) throw new Exception($"Solution {solutionName} not found");

            var solution=result.Entities[0];
            var entityId = solution.GetAttributeValue<Guid>("solutionid");
            Console.WriteLine(entityId);
        }
    }
}