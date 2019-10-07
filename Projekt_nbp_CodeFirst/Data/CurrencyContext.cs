using System.Data.Entity;

namespace Projekt_nbp_CodeFirst.Data
{
    public class CurrencyContext : DbContext
    {
        public static string dataBaseName = "CurrencyDB";

        public CurrencyContext() : base(dataBaseName)
        {
            Database.SetInitializer(new CurrencyDBInitializer());
        }

        public DbSet<Currency> Currencies { get; set; }       
        public DbSet<Date> Dates { get; set; }
        public DbSet<Rate> Rates { get; set; }       
    }
}
