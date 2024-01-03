using CommunityToolkit.Maui.Views;
using KaraKuljaFund.Navigator.Interfaces.Services;
using CommunityToolkit.Maui.Alerts;
using KaraKuljaFund.MAUI.Views.Pages.Contribution;
namespace KaraKuljaFund.MAUI.Views.Controls;


public partial class FloutAction: Expander
{

    
	public FloutAction()
	{
	
		InitializeComponent();
	}

     

    private async void btnHelp_Clicked(object sender, EventArgs e)
    {
        await Toast.Make("On Help clicked").Show();
    }

    private async void btnContribution_Clicked(object sender, EventArgs e)
    {
        var Contribution = new ContributionPage(null);
         await Shell.Current.CurrentPage.ShowPopupAsync(Contribution);
    }
}