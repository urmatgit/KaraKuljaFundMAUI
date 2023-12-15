using CommunityToolkit.Mvvm.ComponentModel;
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
    public partial class RuraGovContributionViewModel(INavigationService navigationService) : BasePageViewModel, IRuraGovContributionViewModel
    {
        private const string fRuralGovDto= "RuralGovDto";
        [ObservableProperty]
        private RuralGovDto _ruralGov; 
        public INavigationService NavigationService { get; } = navigationService;
        public RuralGovDto RuralGovVM
        {
            get { return _ruralGov; }
            set { _ruralGov = value; }
        }

        public override void OnApplyParameters(IParameters parameters)
        {
            IDictionary<string, object> query = parameters as IDictionary<string, object>;
            if (query == null)
            {
                RuralGov = parameters as RuralGovDto;
            }
            else if (query.ContainsKey(fRuralGovDto))
                RuralGov = query[fRuralGovDto] as RuralGovDto;
            base.OnApplyParameters(parameters);
        }
        public override void OnApplyFirstParameters(IParameters parameters)
        {
            base.OnApplyFirstParameters(parameters);
        }

    }
}
