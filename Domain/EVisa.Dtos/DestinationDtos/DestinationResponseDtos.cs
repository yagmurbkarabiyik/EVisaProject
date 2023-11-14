using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dtos.DestinationDtos
{
    public record DestinationCreateResponseDto(int Id, string Name, int CountryId);
    public record DestinationUpdateResponseDto(int Id, string Name, int CountryId);
}
