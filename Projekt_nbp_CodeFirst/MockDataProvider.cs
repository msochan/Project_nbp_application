//using Projekt_nbp_CodeFirst.Data;
//using Projekt_nbp_CodeFirst.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity.Core;
//using System.Globalization;
//using System.Linq;

//namespace Projekt_nbp_CodeFirst
//{
//    class MockDataProvider:IDataProvider
//    {
//        private IList<double> currencyRates;
//        private IList<Chart> chartData;

//        private IList<DateTime> dateList;


//        private double price0 = 3.4022;
//        private double price1 = 3.4055;
//        private double price2 = 3.4177;
//        private double price3 = 3.4224;
//        private double price4 = 3.4301;
//        private double price5 = 3.4315;
//        private double price6 = 3.4234;
//        private double price7 = 3.4190;
//        private double price8 = 3.4174;
//        private double price9  = 3.4068;
//        private double price10 = 3.3859;
//        private double price11 = 3.3924;
//        private double price12 = 3.3862;
//        private double price13 = 3.3789;
//        private double price14 = 3.3704;
//        private double price15 = 3.3666;
//        private double price16 = 3.3572;
//        private double price17 = 3.3721;
//        private double price18 = 3.3693;
//        private double price19 = 3.3881;
//        private double price20 = 3.3950;
//        private double price21 = 3.4050;
//        private double price22 = 3.4156;
//        private double price23 = 3.4401;
//        private double price24 = 3.4548;
//        private double price25 = 3.4827;
//        private double price26 = 3.5003;
//        private double price27 = 3.4890;
//        private double price28 = 3.4870;
//        private double price29 = 3.4868;

//        private string symboL;

//        private Chart data0;
//        private Chart data1;
//        private Chart data2;
//        private Chart data3;
//        private Chart data4;
//        private Chart data5;
//        private Chart data6;
//        private Chart data7;
//        private Chart data8; 
//        private Chart data9;
//        private Chart data10;
//        private Chart data11;
//        private Chart data12;
//        private Chart data13;
//        private Chart data14;
//        private Chart data15;
//        private Chart data16;
//        private Chart data17;
//        private Chart data18;
//        private Chart data19;
//        private Chart data20;
//        private Chart data21;
//        private Chart data22;
//        private Chart data23;
//        private Chart data24;
//        private Chart data25;
//        private Chart data26;
//        private Chart data27;
//        private Chart data28;
//        private Chart data29;


//        public MockDataProvider()
//        {
//            currencyRates=new List<double>();
//            chartData=new List<Chart>();

//            symboL = "USD";

//            dateList = new List<DateTime>();
//            for (int i = 1; i <= 30; i++)           
//                dateList.Add(new DateTime(2018, 4, i));



//            price0 = 3.4022;
//            price1 = 3.4055;
//            price2 = 3.4177;
//            price3 = 3.4224;
//            price4 = 3.4301;
//            price5 = 3.4315;
//            price6 = 3.4234;
//            price7 = 3.4190;
//            price8 = 3.4174;
//            price9 = 3.4068;
//            price10 = 3.3859;
//            price11 = 3.3924;
//            price12 = 3.3862;
//            price13 = 3.3789;
//            price14 = 3.3704;
//            price15 = 3.3666;
//            price16 = 3.3572;
//            price17 = 3.3721;
//            price18 = 3.3693;
//            price19 = 3.3881;
//            price20 = 3.3950;
//            price21 = 3.4050;
//            price22 = 3.4156;
//            price23 = 3.4401;
//            price24 = 3.4548;
//            price25 = 3.4827;
//            price26 = 3.5003;
//            price27 = 3.4890;
//            price28 = 3.4870;
//            price29 = 3.4868;
            

//            data0  = new Chart(dateList[0], price0) ;
//            data1  = new Chart(dateList[1], price1) ;
//            data2  = new Chart(dateList[2], price2) ;
//            data3  = new Chart(dateList[3], price3) ;
//            data4  = new Chart(dateList[4], price4) ;
//            data5  = new Chart(dateList[5], price5) ;
//            data6  = new Chart(dateList[6], price6) ;
//            data7  = new Chart(dateList[7], price7) ;
//            data8  = new Chart(dateList[8], price8) ;
//            data9 = new Chart(dateList[9],  price9 );
//           data10 = new Chart(dateList[10], price10);
//           data11 = new Chart(dateList[11], price11);
//           data12 = new Chart(dateList[12], price12);
//           data13 = new Chart(dateList[13], price13);
//           data14 = new Chart(dateList[14], price14);
//           data15 = new Chart(dateList[15], price15);
//           data16 = new Chart(dateList[16], price16);
//           data17 = new Chart(dateList[17], price17);
//           data18 = new Chart(dateList[18], price18);
//           data19 = new Chart(dateList[19], price19);
//           data20 = new Chart(dateList[20], price20);
//           data21 = new Chart(dateList[21], price21);
//           data22 = new Chart(dateList[22], price22);
//           data23 = new Chart(dateList[23], price23);
//           data24 = new Chart(dateList[24], price24);
//           data25 = new Chart(dateList[25], price25);
//           data26 = new Chart(dateList[26], price26);
//           data27 = new Chart(dateList[27], price27);
//           data28 = new Chart(dateList[28], price28);
//            data29 = new Chart(dateList[29], price29);
            

//        }

//        public IList<double> GetRate(string table, string symbol, DateTime startDate, DateTime endDate)
//        {

//            if (symbol == symboL)
//            {
//                if (startDate == dateList[0] && endDate == dateList[0])
//                {
//                    currencyRates.Add(price0);
//                    //currencyRates.Add(price1);
//                }

//                if (startDate == dateList[0] && endDate == dateList[1])
//                {
//                    currencyRates.Add(price0);
//                    currencyRates.Add(price1);
//                }

//                if (startDate == dateList[0] && endDate == dateList[14])
//                {
//                    currencyRates.Add(price0);
//                    currencyRates.Add(price1);
//                    currencyRates.Add(price2);
//                    currencyRates.Add(price3);
//                    currencyRates.Add(price4);
//                    currencyRates.Add(price5);
//                    currencyRates.Add(price6);
//                    currencyRates.Add(price7);
//                    currencyRates.Add(price8);
//                    currencyRates.Add(price9);
//                    currencyRates.Add(price10);
//                    currencyRates.Add(price11);
//                    currencyRates.Add(price12);
//                    currencyRates.Add(price13);
//                    currencyRates.Add(price14);
//                }

//                if (startDate == dateList[19] && endDate == dateList[29])
//                {
//                    currencyRates.Add(price19);
//                    currencyRates.Add(price18);
//                    currencyRates.Add(price19);
//                    currencyRates.Add(price20);
//                    currencyRates.Add(price21);
//                    currencyRates.Add(price22);
//                    currencyRates.Add(price23);
//                    currencyRates.Add(price24);
//                    currencyRates.Add(price25);
//                    currencyRates.Add(price26);
//                    currencyRates.Add(price27);
//                    currencyRates.Add(price28);
//                    currencyRates.Add(price29);
//                }

//                if (startDate == dateList[4] && endDate == dateList[13])
//                {
//                    currencyRates.Add(price4);
//                    currencyRates.Add(price5);
//                    currencyRates.Add(price6);
//                    currencyRates.Add(price7);
//                    currencyRates.Add(price8);
//                    currencyRates.Add(price9);
//                    currencyRates.Add(price10);
//                    currencyRates.Add(price11);
//                    currencyRates.Add(price12);
//                    currencyRates.Add(price13);                    
//                }

//                if (startDate == dateList[0] && endDate == dateList[29])
//                {
//                    currencyRates.Add(price0);
//                    currencyRates.Add(price1);
//                    currencyRates.Add(price2);
//                    currencyRates.Add(price3);
//                    currencyRates.Add(price4);
//                    currencyRates.Add(price5);
//                    currencyRates.Add(price6);
//                    currencyRates.Add(price7);
//                    currencyRates.Add(price8);
//                    currencyRates.Add(price9);
//                    currencyRates.Add(price10);
//                    currencyRates.Add(price11);
//                    currencyRates.Add(price12);
//                    currencyRates.Add(price13);
//                    currencyRates.Add(price14);
//                    currencyRates.Add(price15);
//                    currencyRates.Add(price16);
//                    currencyRates.Add(price17);
//                    currencyRates.Add(price18);
//                    currencyRates.Add(price19);
//                    currencyRates.Add(price20);
//                    currencyRates.Add(price21);
//                    currencyRates.Add(price22);
//                    currencyRates.Add(price23);
//                    currencyRates.Add(price24);
//                    currencyRates.Add(price25);
//                    currencyRates.Add(price26);
//                    currencyRates.Add(price27);
//                    currencyRates.Add(price28);
//                    currencyRates.Add(price29);
//                }
//            }

//            return currencyRates;
//        }

//        public double CalculateMax(string table, string symbol, DateTime startDate, DateTime endDate)
//        {
//            currencyRates = GetRate(table, symbol, startDate, endDate);

//            return currencyRates.Max();
           
//        }

//        public double CalculateMin(string table, string symbol, DateTime startDate, DateTime endDate)
//        {
//            currencyRates = GetRate(table, symbol, startDate, endDate);

//            return currencyRates.Min();
//        }

//        public double CalculateAvg(string table, string symbol, DateTime startDate, DateTime endDate)
//        {
//            currencyRates = GetRate(table, symbol, startDate, endDate);

//            return currencyRates.Average();
//        }

//        public IList<Chart> GetChartData(string table, string symbol, DateTime startDate, DateTime endDate)
//        {

//            if (symbol == symboL)
//            {
//                if (startDate == dateList[0] && endDate == dateList[0])
//                {
//                    chartData.Add(data0);
//                    //chartData.Add(data1);
//                }

//                if (startDate == dateList[0] && endDate == dateList[1])
//                {
//                    chartData.Add(data0);
//                    chartData.Add(data1);
//                }

//                if (startDate == dateList[0] && endDate == dateList[14])
//                {
//                    chartData.Add(data0);
//                    chartData.Add(data1);
//                    chartData.Add(data2);
//                    chartData.Add(data3);
//                    chartData.Add(data4);
//                    chartData.Add(data5);
//                    chartData.Add(data6);
//                    chartData.Add(data7);
//                    chartData.Add(data8);
//                    chartData.Add(data9);
//                    chartData.Add(data10);
//                    chartData.Add(data11);
//                    chartData.Add(data12);
//                    chartData.Add(data13);
//                    chartData.Add(data14);
//                }

//                if (startDate == dateList[19] && endDate == dateList[29])
//                {
//                    chartData.Add(data19);
//                    chartData.Add(data18);
//                    chartData.Add(data19);
//                    chartData.Add(data20);
//                    chartData.Add(data21);
//                    chartData.Add(data22);
//                    chartData.Add(data23);
//                    chartData.Add(data24);
//                    chartData.Add(data25);
//                    chartData.Add(data26);
//                    chartData.Add(data27);
//                    chartData.Add(data28);
//                    chartData.Add(data29);
//                }

//                if (startDate == dateList[4] && endDate == dateList[13])
//                {
//                    chartData.Add(data4);
//                    chartData.Add(data5);
//                    chartData.Add(data6);
//                    chartData.Add(data7);
//                    chartData.Add(data8);
//                    chartData.Add(data9);
//                    chartData.Add(data10);
//                    chartData.Add(data11);
//                    chartData.Add(data12);
//                    chartData.Add(data13);
//                }

//                if (startDate == dateList[0] && endDate == dateList[29])
//                {
                    
//                    chartData.Add(data0);
//                    chartData.Add(data1);
//                    chartData.Add(data2);
//                    chartData.Add(data3);
//                    chartData.Add(data4);
//                    chartData.Add(data5);
//                    chartData.Add(data6);
//                    chartData.Add(data7);
//                    chartData.Add(data8);
//                    chartData.Add(data9);
//                    chartData.Add(data10);
//                    chartData.Add(data11);
//                    chartData.Add(data12);
//                    chartData.Add(data13);
//                    chartData.Add(data14);
//                    chartData.Add(data15);
//                    chartData.Add(data16);
//                    chartData.Add(data17);
//                    chartData.Add(data18);
//                    chartData.Add(data19);
//                    chartData.Add(data20);
//                    chartData.Add(data21);
//                    chartData.Add(data22);
//                    chartData.Add(data23);
//                    chartData.Add(data24);
//                    chartData.Add(data25);
//                    chartData.Add(data26);
//                    chartData.Add(data27);
//                    chartData.Add(data28);
//                    chartData.Add(data29);
  
//                }
//            }

//            return chartData;
//        }

        
//    }
//}
