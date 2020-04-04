using System;
using System.IO;
using Microsoft.Powerplatform.Cds.Client;
using Microsoft.Xrm.Sdk;

namespace CDSSolutionExport
{
    class Program
    {
        static void Main(string cdsConnectionString, string solutionName, FileInfo outputFile)
        {

            if(string.IsNullOrEmpty(cdsConnectionString)) throw new ArgumentException("cdsConnectionString can't be empty");
            if(string.IsNullOrEmpty(solutionName)) throw new ArgumentException("solutionName can't be empty");
                        
            using(var cdsClient = new CdsServiceClient(cdsConnectionString)){
                if(cdsClient.IsReady){
                    var solManager = new SolutionManager(cdsClient);
                    solManager.GetSolComponents(solutionName);
                }
                else{
                    throw new Exception($"Unknown Connection Error:{cdsClient.LastCdsError}",cdsClient.LastCdsException);
                }
            }

        }
    }
}
