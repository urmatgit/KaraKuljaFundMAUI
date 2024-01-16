using CommunityToolkit.Mvvm.ComponentModel;
using KaraKuljaFund.Navigator.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Models
{
    public partial class ContributionDto: ObservableObject
    {
        [ObservableProperty]
        decimal? summa;
        [ObservableProperty]
        EnumMonths month;
        [ObservableProperty]
        DateTime _date;
        [ObservableProperty]
        private Guid _nativeId;
        [ObservableProperty]
        private string _nativeName;
        [ObservableProperty]
        private YearDto _yearDto;
        [ObservableProperty]
        RuralGovDto _ruralGovDto;
        [ObservableProperty]
        string? _description;
    }
}
