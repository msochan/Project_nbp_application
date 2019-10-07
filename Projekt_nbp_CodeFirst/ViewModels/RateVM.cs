using Projekt_nbp_CodeFirst.Data;
using System.ComponentModel;

namespace Projekt_nbp_CodeFirst.ViewModels
{
    public class RateVM : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string TableNumber { get; set; }

        public Currency Currency { get; set; }
        public Date Date { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        
        
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
