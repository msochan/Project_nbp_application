using Projekt_nbp_CodeFirst.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projekt_nbp_CodeFirst.Interfaces
{

    /// <summary>
    /// Interface that providing data to main functionality of application
    /// </summary>
    interface IDataProvider
    {
        /// <summary>
        /// Getting rates from certain currency from chosen range
        /// </summary>        
        /// <param name="symbol">Currency code</param>
        /// <param name="startDate">Beginning of the date range</param>
        /// <param name="endDate">End of the date range</param>
        /// <returns>Returns list of rates</returns>
        Task<IList<Rate>> GetRateAsync(string symbol, DateTime startDate, DateTime endDate);

        /// <summary>
        /// Calculate max value of rate from certain currency from chosen range
        /// </summary>       
        /// <param name="symbol">Currency code</param>
        /// <param name="startDate">Beginning of the date range</param>
        /// <param name="endDate">End of the date range</param>
        /// <returns>Returns calculated max value</returns>
        double CalculateMax(string symbol, DateTime startDate, DateTime endDate, IList<Rate> rateList);

        /// <summary>
        /// Calculate min value of rate from certain currency from chosen range
        /// </summary>
        /// <param name="symbol">Currency code</param>
        /// <param name="startDate">Beginning of the date range</param>
        /// <param name="endDate">End of the date range</param>
        /// <returns>Returns calculated min value</returns>
        double CalculateMin(string symbol, DateTime startDate, DateTime endDate, IList<Rate> rateList);

        /// <summary>
        /// Calculate avg value of rate from certain currency from chosen range
        /// </summary>
        /// <param name="symbol">Currency code</param>
        /// <param name="startDate">Beginning of the date range</param>
        /// <param name="endDate">End of the date range</param>
        /// <returns>Returns calculated avg value</returns>
        double CalculateAvg(string symbol, DateTime startDate, DateTime endDate, IList<Rate> rateList);

        /// <summary>
        /// Getting list of tuples containing rates from certain currency from chosen range with dates
        /// </summary>
        /// <param name="symbol">Currency code</param>
        /// <param name="startDate">Beginning of the date range</param>
        /// <param name="endDate">End of the date range</param>
        /// <returns>Returns list of tuples prepared for chart drawing</returns>
        IList<Chart> GetChartData(string symbol, DateTime startDate, DateTime endDate, IList<Rate> rateList);
             


    }
}
