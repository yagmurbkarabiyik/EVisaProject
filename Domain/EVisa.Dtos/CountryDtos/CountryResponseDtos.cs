using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dtos.CountryDtos
{
    public record CountryResponseDtos
    {
        public record CountryCreateResponseDto(int Id, string Name, string Type, string Status, string ApplicationType);
        public record CountryUpdateResponseDto(int Id, string Name, string Type, string Status);
        public record CountryGetResponseDto(int Id, string Name, string Type, string Status, string ApplicationType);
    }
}
