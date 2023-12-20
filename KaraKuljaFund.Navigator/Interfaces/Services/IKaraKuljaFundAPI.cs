using KaraKuljaFund.Navigator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Interfaces.Services
{
    public interface IKaraKuljaFundAPI
    {
        Task<List<RuralGovDto>> GetRuralGovs(int? year,int? month);
        Task<List<NativeDto>> GetNativesByRuralGov(Guid ruralGovId,int? year,int? month);
        Task<List<int?>> GetYears();
        Task<List<TotalByNative>> GetTotalByNative(Guid nativeid,int? year);
    }
}
