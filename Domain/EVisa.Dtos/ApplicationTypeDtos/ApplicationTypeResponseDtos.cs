using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dtos.ApplicationTypeDtos
{
    public record ApplicationTypeCreateResponseDto(int Id, string Name, int CountryId);
    public record ApplicationTypeUpdateResponseDto(int Id, string Name, int CountryId);
}
