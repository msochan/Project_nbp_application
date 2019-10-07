using Newtonsoft.Json.Linq;
using Projekt_nbp_CodeFirst.Data;
using System;
using System.Collections.Generic;
using System.Net.Configuration;

namespace Projekt_nbp_CodeFirst
{
    class DbMapper
    {
       
     



        public static IList<Rate> MapObject(string data)
        {
           
          
            JObject obj = JObject.Parse(data);

            string currencyTableFromJson = obj["table"].ToString();
            string currencyNameFromJson = obj["currency"].ToString();
            string currencySymbolCodeFromJson = obj["code"].ToString();

            Currency currency = new Currency();
            

            currency.TableType = currencyTableFromJson;
            currency.Name = currencyNameFromJson;
            currency.SymbolCode = currencySymbolCodeFromJson;

            var rateFromJson = obj["rates"] as JArray;
            IList<Rate> rateList = new List<Rate>();
            

            foreach (var element in rateFromJson)
            {
                Date date = new Date();
                Rate rate = new Rate();

                string noFromJson = element["no"].ToString();
                string dateFromJson = element["effectiveDate"].ToString();
                string priceFromJson = element["mid"].ToString();

                DateTime parsedDate = DateTime.Parse(dateFromJson);

                date.Day = parsedDate.Day;
                date.Month = parsedDate.Month;
                date.Year = parsedDate.Year;


                rate.Date = date;
                rate.Currency = currency;
                rate.TableNumber = noFromJson;

                double price = Convert.ToDouble(priceFromJson);
                rate.Price = price;

                rateList.Add(rate);
            }
            


            return rateList;
        }

    }
}
