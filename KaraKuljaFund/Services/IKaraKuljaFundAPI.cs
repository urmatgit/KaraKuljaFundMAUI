using KaraKuljaFund.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Services
{
    public interface IKaraKuljaFundAPI
    {
        List<RuralGovDto> GetRuralGovs();
    }
}
