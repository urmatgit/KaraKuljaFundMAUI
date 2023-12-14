using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;

namespace KaraKuljaFund.MAUI.Views.Pages;

public partial class HomePage : BaseRootContentPage
{
    public HomePage(IHomePageViewModel viewModel, INavigationService navigationService) : base(navigationService)
    {
        BindingContext = viewModel;

        InitializeComponent();
    }
}