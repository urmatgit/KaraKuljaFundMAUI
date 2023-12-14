using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using KaraKuljaFund.Navigator.Models;
using KaraKuljaFund.Navigator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.MAUI.ViewModels
{
    public class RuraGovContributionViewModel(INavigationService navigationService) : BasePageViewModel, IRuraGovContributionViewModel
    {

        public RuralGovDto RuralGov { get; set; }
        public INavigationService NavigationService { get; } = navigationService;

        public override void OnApplyParameters(IParameters parameters)
        {
            IDictionary<string, object> query = parameters as IDictionary<string, object>;
            RuralGov = query["RuralGovDto"] as RuralGovDto;
            base.OnApplyParameters(parameters);
        }
        public override void OnApplyFirstParameters(IParameters parameters)
        {
            base.OnApplyFirstParameters(parameters);
        }

    }
}
