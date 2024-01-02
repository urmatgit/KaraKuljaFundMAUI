using CommunityToolkit.Maui.Views;
using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;

namespace KaraKuljaFund.MAUI.Views.Pages.Contribution;

public partial class ContributionPage : Popup
{
	public ContributionPage(IContributionViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
		
	}
}