using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KaraKuljaFund.Models;
using KaraKuljaFund.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.ViewModels
{
    public partial class RuralGovViewModel : BaseViewMode, IRuralGovViewModel, IQueryAttributable
    {
        [ObservableProperty] private RuralGovDto _ruralGov;
        public RuralGovViewModel() { }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            RuralGov = query["RuralGovDto"] as RuralGovDto;
        }
        
    }
}
