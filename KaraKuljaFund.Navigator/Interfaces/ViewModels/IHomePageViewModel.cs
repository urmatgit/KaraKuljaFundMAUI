using KaraKuljaFund.Navigator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Interfaces.ViewModels
{
    public interface IHomePageViewModel : IBasePageViewModel
    {
        public   Task<List<RuralGovDto>> ruralGovDtos();
    }
}
