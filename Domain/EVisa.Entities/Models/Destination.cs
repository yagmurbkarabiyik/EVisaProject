using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Entities.Models
{
    public class Destination : BaseEntity
    {
        public string Description { get; set; }
        public int ForeignCountryId { get; set; }
        public int HomeCountryId { get; set; }
        public Country Country { get; set; }
    }
}
