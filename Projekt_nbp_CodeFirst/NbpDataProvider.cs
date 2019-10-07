using Projekt_nbp_CodeFirst.Data;
using Projekt_nbp_CodeFirst.Interfaces;
using Projekt_nbp_CodeFirst.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt_nbp_CodeFirst
{
    class NbpDataProvider:IDataProvider
    {
        private HttpService request;
        private NbpHttpRequestHandler url;       
        private DbService dbService;

        


        public NbpDataProvider()
        {           
            url = new NbpHttpRequestHandler();
            request = new HttpService(NbpHttpRequestHandler.Baseuri);
            dbService=new DbService();
            
        }



        public async Task<IList<Rate>> GetRateAsync(string symbol, DateTime startDate, DateTime endDate)
        {

            IList<Rate> chooseList = new List<Rate>();
            chooseList = dbService.FindRate(symbol, startDate, endDate);

            if (chooseList == null)
            {
                string table = dbService.FindTableCode(symbol);

                var apiResponse = await request.GetRequestAsync(
                    url.GetNbpRatesRequest(table.ToLower(), symbol.ToLower(), startDate, endDate),
                    format: "?format=json");

                
                string path;
                IList<Rate> rateList = new List<Rate>();


                path = apiResponse.responseData;
                    
                rateList = DbMapper.MapObject(path);

                foreach (Rate element in rateList)
                    {
                        Console.WriteLine(element.Price);
                        dbService.AddRate(element);

                    }

                    return rateList;
   
            }

            return chooseList;

        }



        public double CalculateMax(string symbol, DateTime startDate, DateTime endDate, IList<Rate> rateList)
        {
            IList<double> pricesList = new List<double>();
            foreach (var element in rateList)
            {
                pricesList.Add(element.Price);
            }

            return pricesList.Max();
        }

        public double CalculateMin(string symbol, DateTime startDate, DateTime endDate, IList<Rate> rateList)
        {
            IList<double> pricesList = new List<double>();
            foreach (var element in rateList)
            {
                pricesList.Add(element.Price);
            }

            return pricesList.Min();
        }

        public double CalculateAvg(string symbol, DateTime startDate, DateTime endDate, IList<Rate> rateList)
        {
            IList<double> pricesList = new List<double>();
            foreach (var element in rateList)
            {
                pricesList.Add(element.Price);
            }

            return pricesList.Average();
        }

        public IList<Chart> GetChartData(string symbol, DateTime startDate, DateTime endDate, IList<Rate> rateList)
        {
            
            IList<Chart> chartData = new List<Chart>();
            

            foreach (var element in rateList)
            {
                DateTime dateOnChart = new DateTime(element.Date.Year,element.Date.Month,element.Date.Day);
                Chart data = new Chart(dateOnChart, element.Price);
                chartData.Add(data);
                
            }


            return chartData;
        }
    }
}
