using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.ViewModels
{
    public class BasePageViewModel : BaseViewModel, IBasePageViewModel
    {
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
