using KaraKuljaFund.ViewModels.Interfaces;

namespace KaraKuljaFund
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(IMainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext = mainViewModel;
        }

         
    }
}