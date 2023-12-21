using KaraKuljaFund.MAUI.ViewModels;
using KaraKuljaFund.MAUI.Views.Pages.Native;
using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;

namespace KaraKuljaFund.MAUI.Views.Pages.RuralGov;

public partial class RuraGovContributionPage : BaseContentPage
{
	public RuraGovContributionPage(IRuraGovContributionViewModel viewModel , INavigationService navigationService) :base(navigationService)
	{
        BindingContext = viewModel;
        InitializeComponent();
        
	}

    private async void NativeListings_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var mv= this.Handler.MauiContext.Services.GetRequiredService<INativeContributionViewModel>();
        var navigationService = this.Handler.MauiContext.Services.GetRequiredService<INavigationService>();
        await Navigation.PushAsync(new NativeContributionPage(mv, navigationService));
    }
    private void CollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is CollectionView collectionView)
            collectionView.SelectedItem = null;
    }

     
}