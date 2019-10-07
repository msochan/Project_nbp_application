using Projekt_nbp_CodeFirst.Data;
using System;

namespace Projekt_nbp_CodeFirst
{
    /// <summary>
    /// Additional methods which extends date entity from database
    /// </summary>
    public static class DbDateExtensionMethods
    {

        /// <summary>
        /// Checks if date entity from database is equals to date specified in DateTime format
        /// </summary>
        /// <param name="dbDate">Entity with single date from database</param>
        /// <param name="dateTime">Compared date</param>
        /// <returns>Returns true or false</returns>
        public static bool AreDatesEqual(this Date dbDate,DateTime dateTime)
        {
            return dbDate.Day == dateTime.Day &&
                   dbDate.Month == dateTime.Month &&
                   dbDate.Year == dateTime.Year;
        }

        
    }
}
