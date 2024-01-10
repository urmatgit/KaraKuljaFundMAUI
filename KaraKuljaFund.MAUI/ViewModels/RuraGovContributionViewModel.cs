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
    public partial class RuraGovContributionViewModel(INavigationService navigationService, IKaraKuljaFundAPI karaKuljaFundAPI) : BasePageViewModel, IRuraGovContributionViewModel
    {
        private readonly IKaraKuljaFundAPI _karaKuljaFundAPI = karaKuljaFundAPI;
        public const string fRuralGovDto= "RuralGovDto";
        
        [ObservableProperty]
        private bool _loading = true;
        [ObservableProperty]
        private RuralGovDto _ruralGov; 
        public INavigationService NavigationService { get; } = navigationService;
        public RuralGovDto RuralGovVM
        {
            get { return RuralGov; }
            set { RuralGov = value; }
        }
        partial void OnRuralGovChanged(RuralGovDto? oldValue, RuralGovDto newValue)
        {
            Contribution.RuralGovId = newValue.Id;
        }
        [ObservableProperty]
        private List<NativeDto> _natives;


        [ObservableProperty]
        private bool _filterOnlyWithContribution;

        [ObservableProperty]
        string _filterStr;
        partial void OnFilterStrChanged(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                if (value.Length >= 3)
                    Natives = Natives.Where(n => n.Name.Contains(value) || n.Surname.Contains(value) || (n.MiddleName != null ? n.MiddleName.Contains(value) : true)
                    || (string.IsNullOrEmpty(n.Village) ? true : n.Village.Contains(value))).ToList();
            }else if (Natives==null || Natives.Count==0)    
            {
                Task.Factory.StartNew(async () => await LoadNatives(FilterOnlyWithContribution));
                
            }
        }

        partial void OnFilterOnlyWithContributionChanged(bool oldValue, bool newValue)
        {
            
            Task.Factory.StartNew(async () => {
                await LoadNatives(newValue);
                OnFilterStrChanged(FilterStr);
                }
                );

        }

        public override async void OnApplyParameters(IParameters parameters)
        {
            if (parameters == null) return;
            IDictionary<string, object> query = parameters as IDictionary<string, object>;
            if (query == null)
            {
                RuralGov = parameters as RuralGovDto;
            }
            else if (query.ContainsKey(fRuralGovDto))
                RuralGov = query[fRuralGovDto] as RuralGovDto;
            await LoadNatives(FilterOnlyWithContribution);
            base.OnApplyParameters(parameters);
        }
         private async Task LoadNatives(bool onlyContribution=false)
        {
            if (!onlyContribution)
                Natives =  await _karaKuljaFundAPI.GetNativesByRuralGov(RuralGov.Id,2023,1);
            else
            {
                var natives = await _karaKuljaFundAPI.GetNativesByRuralGov(RuralGov.Id, 2023, 1);
                Natives = natives.Where(n=>n.Summ>0).ToList();
            }
            Loading = false;
        }
        public override void OnApplyFirstParameters(IParameters parameters)
        {
            base.OnApplyFirstParameters(parameters);
        }
        [RelayCommand]
        private async void NavigateToNativeDto(NativeDto nativeDto)
        {
            if (nativeDto == null) return;
            var navigationParameter = new ParameterDictionary<string, object>()
            {
                { NativeContributionViewModel.fNativeDto,nativeDto },
                { fRuralGovDto,RuralGov }
            };
            await NavigationService.GoTo(PageType.NativeContributionPage, navigationParameter as IParameters);
            //await Shell.Current.GoToAsync($"RuraGovContributionPage", navigationParameter);
        }
        [RelayCommand]
        private async void NavigateToBack()
        {

            await NavigationService.GoBack();
            //await Shell.Current.GoToAsync($"RuraGovContributionPage");//, navigationParameter);
        }
    }
}
