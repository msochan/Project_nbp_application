namespace Projekt_nbp_CodeFirst.Data
{
    /// <summary>
    /// Class stores Currency price from certain date
    /// </summary>
    public class Rate
    {
        public int Id { get; set; }

        public double Price { get; set; }

        public string TableNumber { get; set; }

        public virtual Currency Currency { get; set; }
     
        public virtual Date Date { get; set; }
    }
}
