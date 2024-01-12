using KaraKuljaFund.Navigator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Interfaces.ViewModels
{
    public interface IRuraGovContributionViewModel: IBasePageViewModel
    {
         public RuralGovDto RuralGovVM { get; set; }
         
    }
}
