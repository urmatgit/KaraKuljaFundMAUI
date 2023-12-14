using KaraKuljaFund.Models;
using KaraKuljaFund.Views.RuralGov;

namespace KaraKuljaFund
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(RuralGovListPage), typeof(RuralGovListPage));
        }
    }
}