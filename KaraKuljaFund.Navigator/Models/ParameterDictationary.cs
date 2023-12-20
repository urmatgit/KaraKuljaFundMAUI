using KaraKuljaFund.Navigator.Interfaces.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Models
{
    public class ParameterDictionary<TKey, TValue> : Dictionary<TKey, TValue>,IParameters
    {
        public ParameterDictionary(): base()
        {
                
        }
    }
}
