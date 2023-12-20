using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
        public NativeContributionViewModel(IKaraKuljaFundAPI karaKuljaFundAPI, INavigationService navigationService)
        {
            _karaKuljaFundAPI = karaKuljaFundAPI;
            _navigationService = navigationService;
            IsNavigatable = false;
            LoadDate();
        }

        private void LoadDate()
        {
            
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
            await _navigationService.GoBack(PageType.RuraGovContributionPage);
            //var navigationParameter = new ParameterDictionary<string, object>()
            //{
                
            //    { RuraGovContributionViewModel.fRuralGovDto ,_rgovDto }
            //};
            //await _navigationService.GoTo(PageType.RuraGovContributionPage, navigationParameter as IParameters);

            //await _navigationService.GoBack(PageType.RuraGovContributionPage);
            //await Shell.Current.GoToAsync($"RuraGovContributionPage");
        }

        public override void OnNavigatedFrom()
        {
            base.OnNavigatedFrom();
        }
    }
}
