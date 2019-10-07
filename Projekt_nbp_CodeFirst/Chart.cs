using System;

namespace Projekt_nbp_CodeFirst
{
    public class Chart
    {
       
        public DateTime date { get; set; }
        public double valuePrice { get; set; }


        public Chart(DateTime date, double value)
        {
            this.date = date;
            this.valuePrice = value;
        }




        
    }
}
