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

    private void CollectionView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (sender is CollectionView collectionView)
            collectionView.SelectedItem = null;
    }
}