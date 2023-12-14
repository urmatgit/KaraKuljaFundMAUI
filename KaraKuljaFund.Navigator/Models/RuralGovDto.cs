using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Models
{
    public class RuralGovDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; }
        public string Coordinate { get; set; }
        public decimal Summa { get; set; }
    }
}
