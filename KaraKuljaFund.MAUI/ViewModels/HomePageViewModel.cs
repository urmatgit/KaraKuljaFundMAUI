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
    public partial class HomePageViewModel : BasePageViewModel, IHomePageViewModel
    {
        private readonly IKaraKuljaFundAPI _karaKuljaFundAPI;
        private readonly INavigationService _navigationService;
        [ObservableProperty]
        private ObservableCollection<RuralGovDto> _ruralGovDtos;

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
            Years = new ObservableCollection<int?>(await _karaKuljaFundAPI.GetYears());
            Months = new ObservableCollection<int?>() { null, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        }



        [ObservableProperty]
        public int? _year;
        [ObservableProperty]
        public int? _month;

        [ObservableProperty]
        public ObservableCollection<int?> _years;

        [ObservableProperty]
        public ObservableCollection<int?> _months;



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
