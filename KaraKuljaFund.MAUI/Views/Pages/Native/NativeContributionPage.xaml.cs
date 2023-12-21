using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;

namespace KaraKuljaFund.MAUI.Views.Pages.Native;

public partial class NativeContributionPage : BaseContentPage
{
	public NativeContributionPage(INativeContributionViewModel viewModel, INavigationService navigationService) : base(navigationService)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PopAsync();
    }
}