using Projekt_nbp_CodeFirst.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Projekt_nbp_CodeFirst.Services
{
    /// <summary>
    /// Class which handles operations on database.
    /// </summary>
    class DbService
    {
      


        public Rate AddRate(Rate rate)
        {
            using (CurrencyContext dbContext = new CurrencyContext())
            {
              
                var dateToUse = GetDate(rate, dbContext);

                var currencyToUse = GetCurrency(rate, dbContext);

                Rate dbRate = dbContext.Rates.AsEnumerable().FirstOrDefault(r => r.Currency == currencyToUse
                                                                                 && r.Date == dateToUse);
                if (dbRate != null)
                    return dbRate;


                var newRate = dbContext.Rates.Add(new Rate
                {
                    Price = rate.Price,
                    Currency = currencyToUse,
                    Date = dateToUse,
                    TableNumber = rate.TableNumber

                });
                dbContext.SaveChanges();


                return newRate;
            }

        }

        public Date GetDate(Rate rate, CurrencyContext dbContext)
        {
            Date dbDate = dbContext.Dates.FirstOrDefault(d => d.Day == rate.Date.Day
                                                              && d.Month == rate.Date.Month
                                                              && d.Year == rate.Date.Year);
            var dateToUse = dbDate ?? new Date()
            {
                Day = rate.Date.Day,
                Month = rate.Date.Month,
                Year = rate.Date.Year
            };

            if (dateToUse != dbDate)
            {
                dbContext.Dates.Add(dateToUse);
                dbContext.SaveChanges();
            }
                

            return dateToUse;
        }

        public IList<Rate> FindRate(string symbol, DateTime startDate, DateTime endDate)
        {
            using (CurrencyContext dbContext = new CurrencyContext())
            {
                IList<Rate> rateList = new List<Rate>();

                for (DateTime i = startDate; i < endDate; i = i.AddDays(1))
                {
                    Rate dbRate = dbContext.Rates.AsEnumerable().FirstOrDefault(r => (r.Date).AreDatesEqual(i) && r.Currency.SymbolCode == symbol);
                    rateList.Add(dbRate);
                    if (dbRate == null)
                        return null;
                }

                return rateList;
            }
       
        }

        public Currency GetCurrency(Rate rate, CurrencyContext dbContext)
        {
            Currency dbCurrency = dbContext.Currencies.FirstOrDefault(c => c.Name.Equals(rate.Currency.Name));

            var currencyToUse = dbCurrency ?? rate.Currency;
            if (currencyToUse.Name != rate.Currency.Name)
            {
                dbContext.Currencies.Add(currencyToUse);
                dbContext.SaveChanges();
            }

            return currencyToUse;
        }

        public string FindTableCode(string symbolCode)
        {
            string tableType = String.Empty;

          
                using (CurrencyContext dbContext = new CurrencyContext())
                {

                    Currency dbCurrency = dbContext.Currencies.FirstOrDefault(c => c.SymbolCode == symbolCode);

                    if(dbCurrency!=null)
                    return tableType = dbCurrency.TableType;
                    else
                    {
                        tableType = "Currency not found!";
                        MessageBox.Show(tableType);
                        return tableType;
                    }

                }
            
            
        }
    }
}
