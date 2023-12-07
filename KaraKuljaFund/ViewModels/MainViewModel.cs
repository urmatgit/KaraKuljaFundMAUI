using CommunityToolkit.Mvvm.ComponentModel;
using KaraKuljaFund.Models;
using KaraKuljaFund.Services;
using KaraKuljaFund.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.ViewModels
{
    internal partial class MainViewModel: BaseViewMode,IMainViewModel
    {
        private readonly IKaraKuljaFundAPI _karaKuljaFundAPI;
        [ObservableProperty] private ObservableCollection<RuralGovDto> _ruralGovs;
        public MainViewModel(IKaraKuljaFundAPI karaKuljaFundAPI)
        {
            _karaKuljaFundAPI = karaKuljaFundAPI;
            LoadData();
        }

        private void LoadData()
        {
            _ruralGovs=new ObservableCollection<RuralGovDto>(_karaKuljaFundAPI.GetRuralGovs());
        }
    }
}
