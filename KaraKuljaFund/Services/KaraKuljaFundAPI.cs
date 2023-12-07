using KaraKuljaFund.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Services
{
    public class KaraKuljaFundAPI : IKaraKuljaFundAPI
    {
        public List<RuralGovDto> GetRuralGovs()
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
