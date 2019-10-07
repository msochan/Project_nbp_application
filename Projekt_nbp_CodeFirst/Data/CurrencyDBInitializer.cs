using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Net;
using System.Xml;

namespace Projekt_nbp_CodeFirst.Data
{
    public class CurrencyDBInitializer : DropCreateDatabaseIfModelChanges<CurrencyContext>
    {

      
        protected override void Seed(CurrencyContext context)
        {
            DateTime today = DateTime.Now;
            string todayDate = today.Date.ToShortDateString();

            context.Currencies.AddRange(InitCurrencies("http://www.nbp.pl/kursy/xml/a117z180619.xml", $"currenciesA_{todayDate}.xml","A"));
            context.Currencies.AddRange(InitCurrencies("http://www.nbp.pl/kursy/xml/b024z180613.xml", $"currenciesB_{todayDate}.xml","B"));

            base.Seed(context);
        }

        private IList<Currency> InitCurrencies(string xmlFilePath, string currenciesOutputFileName, string table)
        {

            string currenciesXmlNbpFileString;
            using (var client = new WebClient())
            {
                currenciesXmlNbpFileString = client.DownloadString(xmlFilePath);
            }

            File.WriteAllText(currenciesOutputFileName, currenciesXmlNbpFileString);

            IList<Currency> defaultCurrencies = new List<Currency>();


            XmlTextReader reader = new XmlTextReader(currenciesOutputFileName);
            string currencyName = String.Empty;
            string currencyCode = String.Empty;
            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) && reader.Name == "nazwa_waluty")
                {
                    currencyName = reader.ReadString();

                }

                if ((reader.NodeType == XmlNodeType.Element) && reader.Name == "kod_waluty")
                {
                    currencyCode = reader.ReadString();
                    defaultCurrencies.Add(new Currency()
                    {
                        Name = currencyName,
                        SymbolCode = currencyCode,
                        TableType = table
                    });
                }

            }

            return defaultCurrencies;
        }



    }
}
