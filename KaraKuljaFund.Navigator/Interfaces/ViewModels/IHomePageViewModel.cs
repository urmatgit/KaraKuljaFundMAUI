using KaraKuljaFund.Navigator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Interfaces.ViewModels
{
    public interface IHomePageViewModel : IBasePageViewModel
    {
        public ObservableCollection<RuralGovDto> RuralGovDtos { get; set; }
        public int? Year { get; set; }
        public ObservableCollection<int?> Years { get; }
    }
}
