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
    public partial class HomePageViewModel : BasePageViewModel, IHomePageViewModel
    {
        private readonly IKaraKuljaFundAPI _karaKuljaFundAPI;
        private readonly INavigationService _navigationService;
        public HomePageViewModel(IKaraKuljaFundAPI karaKuljaFundAPI,INavigationService navigationService)
        {
            _karaKuljaFundAPI = karaKuljaFundAPI;
            _navigationService = navigationService;
        }
        public List<RuralGovDto> ruralGovDtos
        {
            get
            {
                var govs = _karaKuljaFundAPI.GetRuralGovs().Result;
                return  govs;
            }
        }
        public override void OnNavigatedTo()
        {
            base.OnNavigatedTo();
        }
        [RelayCommand]
        private async void NavigateToRuralGov(RuralGovDto ruralGov)
        {
            var navigationParameter = new Dictionary<string, object>()
            {
                { "RuralGovDto",ruralGov }
            };
           await _navigationService.GoTo(PageType.RuraGovContributionPage, ruralGov);
            //await Shell.Current.GoToAsync($"RuraGovContributionPage", navigationParameter);
        }
    }
}
