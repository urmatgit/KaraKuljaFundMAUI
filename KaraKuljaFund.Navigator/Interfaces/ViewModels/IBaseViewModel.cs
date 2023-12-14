using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Interfaces.ViewModels
{
    public interface IBaseViewModel :  INotifyPropertyChanged
    {
        void OnPropertyChanged(string propertyName);
    }
}
