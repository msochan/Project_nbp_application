using System.Collections.Generic;

namespace Projekt_nbp_CodeFirst.Data
{
    public class Date
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public virtual ICollection<Rate> Rates { get; set; }
    }
}
