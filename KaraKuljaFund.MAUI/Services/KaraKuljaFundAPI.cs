using Android.Views;
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
        public static readonly Guid TestId = Guid.NewGuid();
        public async Task<List<NativeDto>> GetNativesByRuralGov(Guid ruralGovId)
        {
            List<NativeDto> natives = new List<NativeDto>();
            for(var i = 0; i < 20; i++)
            {
                string strI = i.ToString();
                var native=new NativeDto()
                {
                   Name =$"Name_{strI}" ,
                   Surname=$"Surname_{strI}",
                   MiddleName = $"MiddleName_{strI}",
                   BirthDate=new DateTime(2000,1,1),
                   Village="kara-kulja",
                   Summ=1000
                };
                natives.Add(native);
            }
            return natives;
        }

        public async Task<List<RuralGovDto>> GetRuralGovs()
        {
            return new List<RuralGovDto> {
                new RuralGovDto()
                {
                    Id=TestId,
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
