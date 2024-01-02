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
    public partial class ContributionViewModel: BasePageViewModel, IContributionViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IKaraKuljaFundAPI _kuljaFundAPI;
        public ContributionViewModel(IKaraKuljaFundAPI karaKuljaFundAPI, INavigationService navigationService)
        {
            _kuljaFundAPI= karaKuljaFundAPI;
            _navigationService= navigationService;
        }
        [ObservableProperty]
        ContributionDto _contribution;
    }
}
