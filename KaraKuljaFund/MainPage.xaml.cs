using KaraKuljaFund.ViewModels.Interfaces;
using KaraKuljaFund.Views.RuralGov;

namespace KaraKuljaFund
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(IMainViewModel mainViewModel)
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RuraGovPage), typeof(RuraGovPage));
            BindingContext = mainViewModel;
        }
        private void CollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //CollectionView collectionView = sender as CollectionView;
            // collectionView.SelectedItem = null;
        }

    }
}