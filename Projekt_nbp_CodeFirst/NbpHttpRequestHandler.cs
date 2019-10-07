using System;

namespace Projekt_nbp_CodeFirst
{
    class NbpHttpRequestHandler
    {       
        public const string Baseuri = "http://api.nbp.pl/api/";




        public string GetNbpRatesRequest(string table, string code, DateTime startDate, DateTime endDate)
        {

            string parametersPath = $"exchangerates/rates/{table}/{code}/{startDate:yyyy-MM-dd}/{endDate:yyyy-MM-dd}/";

            string requestPath = Baseuri + parametersPath;

            return requestPath;
        }

    }
}
