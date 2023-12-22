using KaraKuljaFund.Navigator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Interfaces.ViewModels
{
    public interface INativeContributionViewModel: IBasePageViewModel
    {
         NativeDto NativeDto { get; set; }
         List<ContributionDto> NativeContributions { get; set; }
    }
}
