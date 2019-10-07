using Projekt_nbp_CodeFirst.ViewModels;
using System.Windows;


namespace Projekt_nbp_CodeFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new CurrencyManagerVM();
        }
    }
}
