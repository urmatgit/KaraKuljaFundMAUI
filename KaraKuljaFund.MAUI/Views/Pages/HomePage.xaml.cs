using CommunityToolkit.Mvvm.Input;
using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using KaraKuljaFund.Navigator.Models;
using SimpleToolkit.Core;

namespace KaraKuljaFund.MAUI.Views.Pages;

public partial class HomePage : BaseRootContentPage
{
    public HomePage(IHomePageViewModel viewModel, INavigationService navigationService) : base(navigationService)
    {
        BindingContext = viewModel;

        InitializeComponent();
    }

     
    private void CollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //CollectionView collectionView = sender as CollectionView;
        // collectionView.SelectedItem = null;
    }
}