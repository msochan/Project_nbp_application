using Projekt_nbp_CodeFirst.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using Projekt_nbp_CodeFirst.Data;

namespace Projekt_nbp_CodeFirst.ViewModels
{


    public class CurrencyManagerVM : INotifyPropertyChanged
    {
        
        private DateTime selectedDateFrom;
        private DateTime selectedDateTo;
        private IList<Chart> chartItems;
        private string singleCurrency;
                
        public ICommand GetRateCommand { get; set; }

        private string average = string.Empty;
        private string max = string.Empty;
        private string min = string.Empty;


        public CurrencyManagerVM()
        {
                
            selectedDateFrom = new DateTime(2021, 11, 3);
            selectedDateTo = new DateTime(2021, 12, 25);       
            chartItems = new List<Chart>();
        
            Currencies = new ObservableCollection<string>
            {
                "USD",
                "EUR",
                "GBP",
                "AUD",
                "JPY",
                "CHF",
                "CAD",
                "NOK",
                "SEK",
                "RUB",
                "CZK",
                "HKD"
            };

            GetRateCommand = new RelayCommand(this.GetRateButtonAsync);
            
        }
    
        public event PropertyChangedEventHandler PropertyChanged;

        public string Average
        {
            set
            {
                average = value;
                RaisePropertyChanged(nameof(Average));
            }
            get => average;
        }

        public string Max
        {
            set
            {
                max = value;
                RaisePropertyChanged(nameof(Max));
            }
            get => max;
        }
        public string Min
        {
            set
            {
                min = value;
                RaisePropertyChanged(nameof(Min));
            }
            get => min;
        }
       

        public DateTime SelectedDateFrom
        {
            get => selectedDateFrom;
            
            set
            {
                if (!selectedDateFrom.Equals(value))
                {
                    selectedDateFrom = value;
                    RaisePropertyChanged(nameof(SelectedDateFrom));
                }
            }
        }

        public DateTime SelectedDateTo
        {
            get => selectedDateTo;

            set
            {
                if (!selectedDateTo.Equals(value))
                {
                    selectedDateTo = value;
                    RaisePropertyChanged(nameof(SelectedDateTo));
                }
            }
        }



        public IList<Chart> ChartItems
        {
            get => chartItems;

            set
            {
                chartItems = value;
                RaisePropertyChanged(nameof(ChartItems));
            }
        }


        public ObservableCollection<string> Currencies { get; set; }




        public string SingleCurrency
        {
            get => singleCurrency;
            set
            {
                singleCurrency = value;
                RaisePropertyChanged(nameof(SingleCurrency));

            } 
        }



        public void RaisePropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        public async void GetRateButtonAsync()
        {


            NbpDataProvider request = new NbpDataProvider();
            IList<Rate> rateList = new List<Rate>();
            rateList = await request.GetRateAsync(singleCurrency, selectedDateFrom, selectedDateTo);

            Average = request.CalculateAvg(singleCurrency, selectedDateFrom, selectedDateTo, rateList).ToString();
            Max = request.CalculateMax(singleCurrency, selectedDateFrom, selectedDateTo, rateList).ToString();
            Min = request.CalculateMin(singleCurrency, selectedDateFrom, selectedDateTo, rateList).ToString();
            ChartItems = request.GetChartData(singleCurrency, selectedDateFrom, selectedDateTo, rateList);

        }



    }
}
