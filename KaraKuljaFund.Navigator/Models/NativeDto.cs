using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraKuljaFund.Navigator.Models
{
    public class NativeDto 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? MiddleName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? ImagePath { get; set; }
        public string? Village { get; set; }
        public string? Description { get; set; }
        //Rating of person

        public int Rate { get; set; } = 5;

        public Guid RuralGovId { get; set; }
        public string RuralGovName { get; set; }
        public decimal? Summ { get; set; }
    }
}
