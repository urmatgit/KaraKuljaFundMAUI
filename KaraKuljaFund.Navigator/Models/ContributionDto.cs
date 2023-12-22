using KaraKuljaFund.Navigator.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Models
{
    public class ContributionDto
    {
        public decimal Summa { get; set; }
        public Months Month { get; set; }
        public DateTime Date { get; set; }
        public Guid NativeId { get; set; }
        public Guid YearId { get; set; }
        
        public string? Description { get; set; }
    }
}
