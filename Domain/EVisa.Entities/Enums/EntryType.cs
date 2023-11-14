using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Entities.Enums
{
    public enum EntryType
    {
        [Display(Name = "Active")]
        Active = 1,

        [Display(Name = "Passive")]
        Passive = 2,

        [Display(Name = "Delete")]
        Delete = 3
    }
}
