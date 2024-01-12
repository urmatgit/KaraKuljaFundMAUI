using CommunityToolkit.Mvvm.ComponentModel;
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
    public partial class ContributionBasePageViewModel : BasePageViewModel
    {
        [ObservableProperty]
        private static ObservableCollection<YearDto> _years;

        [ObservableProperty]
        private static ObservableCollection<EnumMonths> _months;

        [ObservableProperty]
        private static ObservableCollection<RuralGovDto> _ruralGovDtos;

        [ObservableProperty]
        private static List<NativeDto> _natives;

        [ObservableProperty]
        static ContributionDto _contribution;
    }
}
