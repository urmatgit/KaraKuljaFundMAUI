using CommunityToolkit.Mvvm.ComponentModel;
using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.ViewModels
{
    public partial class BasePageViewModel : BaseViewModel, IBasePageViewModel
    {
        [ObservableProperty]
        bool _isNavigatable = true;

        public virtual void OnApplyParameters(IParameters parameters)
        {
        }

        public virtual void OnApplyFirstParameters(IParameters parameters)
        {
        }

        public virtual void OnApplyOtherParameters(IParameters parameters)
        {
        }

        public virtual void OnNavigatedTo()
        {
        }

        public virtual void OnNavigatedFrom()
        {
        }
    }
}
