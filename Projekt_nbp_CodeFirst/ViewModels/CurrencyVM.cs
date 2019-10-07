using Projekt_nbp_CodeFirst.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Projekt_nbp_CodeFirst.ViewModels
{
    public class CurrencyVM : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SymbolCode { get; set; }
        public string TableType { get; set; }

        public ObservableCollection<Rate> Rates { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
       
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
