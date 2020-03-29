using System;
using System.IO;
using Microsoft.Powerplatform.Cds.Client;
using Microsoft.Xrm.Sdk;

namespace src
{
    class Program
    {
        static void Main(string cdsConnectionString, string solutionName, FileInfo outputFile)
        {

            if(string.IsNullOrEmpty(cdsConnectionString)) throw new ArgumentException("cdsConnectionString can't be empty");
            var cdsClient = new CdsServiceClient(cdsConnectionString);

            if(cdsClient.IsReady){
                // var whoAmIRequest =  ();
                // cdsClient.Execute(whoAmIRequest);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
