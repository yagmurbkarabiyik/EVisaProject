using EVisa.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Entities.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

		public EntryType Status { get; set; }

		public string StatusAsString
		{
			get => Enum.GetName(typeof(EntryType), Status);
			set
			{
				if (Enum.TryParse(value, out EntryType entryType))
				{
					Status = entryType;
				}
				else
				{
					Console.WriteLine("Böyle bir status kodu yoktur.");
				}
			}
		}
	}
}
