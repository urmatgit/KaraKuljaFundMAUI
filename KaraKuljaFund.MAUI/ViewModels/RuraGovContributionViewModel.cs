using CommunityToolkit.Mvvm.ComponentModel;
using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using KaraKuljaFund.Navigator.Models;
using KaraKuljaFund.Navigator.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.MAUI.ViewModels
{
    public partial class RuraGovContributionViewModel(INavigationService navigationService, IKaraKuljaFundAPI karaKuljaFundAPI) : BasePageViewModel, IRuraGovContributionViewModel
    {
        private readonly IKaraKuljaFundAPI _karaKuljaFundAPI = karaKuljaFundAPI;
        private const string fRuralGovDto= "RuralGovDto";
        [ObservableProperty]
        private bool _loading = true;
        [ObservableProperty]
        private RuralGovDto _ruralGov; 
        public INavigationService NavigationService { get; } = navigationService;
        public RuralGovDto RuralGovVM
        {
            get { return _ruralGov; }
            set { _ruralGov = value; }
        }
        [ObservableProperty]
        public ObservableCollection<NativeDto> _natives;

        public override async void OnApplyParameters(IParameters parameters)
        {
            IDictionary<string, object> query = parameters as IDictionary<string, object>;
            if (query == null)
            {
                RuralGov = parameters as RuralGovDto;
            }
            else if (query.ContainsKey(fRuralGovDto))
                RuralGov = query[fRuralGovDto] as RuralGovDto;
            await LoadNatives();
            base.OnApplyParameters(parameters);
        }
         private async Task LoadNatives()
        {
            Natives = new ObservableCollection<NativeDto>( await _karaKuljaFundAPI.GetNativesByRuralGov(RuralGov.Id,2023,1));
            Loading = false;
        }
        public override void OnApplyFirstParameters(IParameters parameters)
        {
            base.OnApplyFirstParameters(parameters);
        }

    }
}
