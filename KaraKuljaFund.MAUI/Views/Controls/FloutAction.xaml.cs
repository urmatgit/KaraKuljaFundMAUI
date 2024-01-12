using CommunityToolkit.Maui.Views;
using KaraKuljaFund.Navigator.Interfaces.Services;
using CommunityToolkit.Maui.Alerts;
using KaraKuljaFund.MAUI.Views.Pages.Contribution;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using KaraKuljaFund.MAUI.ViewModels;
using KaraKuljaFund.Navigator.ViewModels;
namespace KaraKuljaFund.MAUI.Views.Controls;


public partial class FloutAction: Expander
{

    private readonly INavigationService _navigationService;

    public FloutAction()
	{
        _navigationService = Application.Current.Handler.MauiContext?.Services.GetRequiredService<INavigationService>();
        InitializeComponent();
	}

    

    private async void btnHelp_Clicked(object sender, EventArgs e)
    {
        await Toast.Make("On Help clicked").Show();
    }

    private async void btnContribution_Clicked(object sender, EventArgs e)
    {

        
        await _navigationService.GoToPopUp(PageType.ContributionPopUp);
    }
}