﻿using EVisa.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Entities.Models
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public ICollection<ApplicationType> ApplicationType { get; set; }
        public ICollection<Destination> Destinations { get; set; }

		
	}
}
