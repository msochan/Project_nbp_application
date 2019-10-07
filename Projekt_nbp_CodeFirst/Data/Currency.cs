using System.Collections.Generic;

namespace Projekt_nbp_CodeFirst.Data
{
    /// <summary>
    /// Basic information about Currency
    /// </summary>
    public class Currency
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SymbolCode { get; set; }

        public string TableType { get; set; }

        public virtual ICollection<Rate> Rates { get; set; }        
    }
}
