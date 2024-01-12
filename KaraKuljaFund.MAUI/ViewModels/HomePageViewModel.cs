using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using KaraKuljaFund.Navigator.Models;
using KaraKuljaFund.Navigator.Models.Enums;
using KaraKuljaFund.Navigator.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.MAUI.ViewModels
{
    public partial class HomePageViewModel : ContributionBasePageViewModel, IHomePageViewModel
    {
        private readonly IKaraKuljaFundAPI _karaKuljaFundAPI;
        private readonly INavigationService _navigationService;
        

        public HomePageViewModel(IKaraKuljaFundAPI karaKuljaFundAPI,INavigationService navigationService)
        {
            _karaKuljaFundAPI = karaKuljaFundAPI;
            _navigationService = navigationService;
            LoadDate();
        }

        private async  Task LoadDate()
        {
            var govs = await _karaKuljaFundAPI.GetRuralGovs(2023, 1);
            RuralGovDtos = new ObservableCollection<RuralGovDto>(govs.OrderBy(g=>g.Summa));
            Years = new ObservableCollection<YearDto>(await _karaKuljaFundAPI.GetYears());
            Months = new ObservableCollection<EnumMonths>() { EnumMonths.January,EnumMonths.February,EnumMonths.March, EnumMonths.April, EnumMonths.May, EnumMonths.June, EnumMonths.July, EnumMonths.August, EnumMonths.September, EnumMonths.October, EnumMonths.November, EnumMonths.December};
            Contribution = new ContributionDto();
        }

        partial void OnMonthChanged(int? oldValue, int? newValue)
        {
            Contribution.Month = newValue is null ? Navigator.Models.Enums.EnumMonths.January : (EnumMonths)newValue.Value;
        }
        partial void OnYearChanged(YearDto oldValue, YearDto newValue)
        {
            Contribution.YearDto = newValue;
        }
        [ObservableProperty]
        public YearDto _year;
        [ObservableProperty]
        public int? _month;

      



        public override void OnNavigatedTo()
        {
            base.OnNavigatedTo();
        }
        [RelayCommand]
        private async void NavigateToRuralGov(RuralGovDto ruralGov)
        {
            if (ruralGov is null) return;
            var navigationParameter = new Dictionary<string, object>()
            {
                { "RuralGovDto",ruralGov }
            };
           await _navigationService.GoTo(PageType.RuraGovContributionPage, ruralGov);
            //await Shell.Current.GoToAsync($"RuraGovContributionPage", navigationParameter);
        }
    }
}
