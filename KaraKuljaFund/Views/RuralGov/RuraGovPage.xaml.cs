using KaraKuljaFund.ViewModels.Interfaces;

namespace KaraKuljaFund.Views.RuralGov;

public partial class RuraGovPage : ContentPage
{
	public RuraGovPage(IRuralGovViewModel ruralGovViewModel)
	{
		InitializeComponent();
		BindingContext = ruralGovViewModel;
	}
    private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}