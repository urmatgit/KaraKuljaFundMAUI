using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.MAUI.Services
{
    public class KaraKuljaFundAPI : IKaraKuljaFundAPI
    {
        public async Task<List<RuralGovDto>> GetRuralGovs()
        {
            return new List<RuralGovDto> {
                new RuralGovDto()
                {
                    Id=Guid.NewGuid(),
                    Name="RuralGov1",
                    Coordinate="1",
                    Summa=100000
                },
                new RuralGovDto()
                {
                    Id=Guid.NewGuid(),
                    Name="RuralGov2",
                    Coordinate="1",
                    Summa=100000
                },
                new RuralGovDto()
                {
                    Id=Guid.NewGuid(),
                    Name="RuralGov3",
                    Summa=100000
                },
                new RuralGovDto()
                {
                    Id=Guid.NewGuid(),
                    Name="RuralGov4",
                    Summa=100000
                },new RuralGovDto()
                {
                    Id=Guid.NewGuid(),
                    Name="RuralGov5",
                    Summa=100000
                },
            };
        }
    }
}
