using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using KaraKuljaFund.Navigator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.ViewModels
{
    public class HomePageViewModel : BasePageViewModel, IHomePageViewModel
    {
        private readonly IKaraKuljaFundAPI _karaKuljaFundAPI;
        public HomePageViewModel(IKaraKuljaFundAPI karaKuljaFundAPI)
        {
            _karaKuljaFundAPI = karaKuljaFundAPI;
        }
        public async Task<List<RuralGovDto>> ruralGovDtos()
        {
            return await _karaKuljaFundAPI.GetRuralGovs();
        } 
    }
}
