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
    
}