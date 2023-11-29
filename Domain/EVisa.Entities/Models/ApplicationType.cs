using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Entities.Models
{
    public class ApplicationType : BaseEntity
    {
        public string Name { get; set; }
        public int EntryType { get; set; }
        public int CountryId { get; set; }
        public int? ProcessingTime { get; set; }
        public int? DurationOfStay { get; set; }
        public int VisaValidity { get; set; }
        public int Price { get; set; }
        public Country? Country { get; set; }
    }
}
