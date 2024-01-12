

using KaraKuljaFund.Navigator.Interfaces.Services;
using KaraKuljaFund.Navigator.Models;
using KaraKuljaFund.Navigator.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.MAUI.Services
{
    public class KaraKuljaFundAPI : IKaraKuljaFundAPI
    {
        public static readonly Guid TestId = Guid.NewGuid();
        public async Task<List<NativeDto>> GetNativesByRuralGov(Guid ruralGovId, int? year, int? month)
        {
            List<NativeDto> natives = new List<NativeDto>();
            for(var i = 0; i < 10; i++)
            {
                string strI = i.ToString();
                var native=new NativeDto()
                {
                   Name =$"Name_{strI}" ,
                   Surname=$"Surname_{strI}",
                   MiddleName = $"MiddleName_{strI}",
                   BirthDate=new DateTime(2000,1,1),
                   Village="kara-kulja",
                   Summ=1000+(i*10)
                };
                natives.Add(native);
            }
            for (var i = 0; i < 5; i++)
            {
                string strI = i.ToString();
                var native = new NativeDto()
                {
                    Name = $"Name_2{strI}",
                    Surname = $"Surname_2{strI}",
                    MiddleName = $"MiddleName_2{strI}",
                    BirthDate = new DateTime(2000, 1, 2),
                    Village = "kara-kulja",
                    Summ = 0
                };
                natives.Add(native);
            }
            return natives;
        }

        public async Task<List<RuralGovDto>> GetRuralGovs(int? year,int? month)
        {
            return new List<RuralGovDto> {
                new RuralGovDto()
                {
                    Id=TestId,
                    Name="RuralGov1",
                    Coordinate="1",
                    Summa=40000
                },
                new RuralGovDto()
                {
                    Id=Guid.NewGuid(),
                    Name="RuralGov2",
                    Coordinate="1",
                    Summa=500000
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
                    Summa=600000
                },new RuralGovDto()
                {
                    Id=Guid.NewGuid(),
                    Name="RuralGov5",
                    Summa=800000
                },
            };
        }

        public Task<List<ContributionDto>> GetNativeContributions(Guid nativeid, Guid ruralGovId, int? year)
        {
            var natives = new List<ContributionDto>();
            natives.Add(new ContributionDto()
            {
                Date = DateTime.Now,
                Summa = 200,
                Month = EnumMonths.January,
            });
            natives.Add(new ContributionDto()
            {
                Date = DateTime.Now,
                Summa = 200,
                Month = EnumMonths.February,
            });
            natives.Add(new ContributionDto()
            {
                Date = DateTime.Now,
                Summa = 200,
                Month = EnumMonths.March,
            });
            natives.Add(new ContributionDto()
            {
                Date = DateTime.Now,
                Summa = 200,
                Month = EnumMonths.May,
            });
            natives.Add(new ContributionDto()
            {
                Date = DateTime.Now,
                Summa = 200,
                Month = EnumMonths.August,
            });
            return Task.FromResult(natives);
        }


        public async Task<List<YearDto>> GetYears()
        {
            List<YearDto> years = new List<YearDto>();
            years.Add(null);
            years.Add(new YearDto() { Id = Guid.NewGuid(), Year = 2022 });
            years.Add(new YearDto() { Id = Guid.NewGuid(), Year = 2023 });
            years.Add(new YearDto() { Id = Guid.NewGuid(), Year = 2024 });
            return years;
        }
    }
}
