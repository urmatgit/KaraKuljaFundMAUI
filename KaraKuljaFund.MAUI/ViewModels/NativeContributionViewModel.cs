using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
   public partial class NativeContributionViewModel: BasePageViewModel, INativeContributionViewModel
    {
        public const string fNativeDto = "NativeDto";
        private readonly IKaraKuljaFundAPI _karaKuljaFundAPI;
        private readonly INavigationService _navigationService;
        
        [ObservableProperty]
        private NativeDto _nativeDto;
        [ObservableProperty]
        private List<NativeDto> _natives;
        private RuralGovDto _rgovDto;
        [ObservableProperty]
        private List<ContributionDto> _nativeContributions;
        

        public NativeContributionViewModel(IKaraKuljaFundAPI karaKuljaFundAPI, INavigationService navigationService)
        {
            _karaKuljaFundAPI = karaKuljaFundAPI;
            _navigationService = navigationService;
            IsNavigatable = false;
            Task.Factory.StartNew(async ()=>   await LoadDate());
        }
        partial void OnNativeDtoChanged(NativeDto? oldValue, NativeDto newValue)
        {
            Contribution.NativeId = NativeDto.Id;
        }
        private async Task LoadDate()
        {
            NativeContributions = await _karaKuljaFundAPI.GetNativeContributions(Guid.NewGuid(), Guid.NewGuid(), 2023);
        }
        
        public override void OnApplyParameters(IParameters parameters)
        {
            IDictionary<string, object> query = parameters as IDictionary<string, object>;
            if (query == null)
            {
                NativeDto = parameters as NativeDto;
            }
            else
            {
                if (query.ContainsKey(fNativeDto))
                    NativeDto = query[fNativeDto] as NativeDto;
                if (query.ContainsKey(RuraGovContributionViewModel.fRuralGovDto))
                {
                    _rgovDto= query[RuraGovContributionViewModel.fRuralGovDto] as RuralGovDto;
                }
            }
            Natives=new List<NativeDto> { NativeDto };
            base.OnApplyParameters(parameters);
        }
        [RelayCommand]
        private async void NavigateToBack()
        {
            await _navigationService.GoBack();
            
        }

        public override void OnNavigatedFrom()
        {
            base.OnNavigatedFrom();
        }
    }
}
