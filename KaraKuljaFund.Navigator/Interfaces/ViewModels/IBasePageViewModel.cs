using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Interfaces.ViewModels
{
    public interface IBasePageViewModel
    {
        void OnNavigatedTo();
        void OnNavigatedFrom();
        void OnApplyParameters(IParameters parameters);
        void OnApplyFirstParameters(IParameters parameters);
        void OnApplyOtherParameters(IParameters parameters);
    }
}
