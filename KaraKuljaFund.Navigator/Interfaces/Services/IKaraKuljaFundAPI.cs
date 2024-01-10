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
        Task<List<YearDto>> GetYears();
        Task<List<ContributionDto >> GetNativeContributions(Guid nativeid,Guid ruralGovId, int? year);
    }
}
