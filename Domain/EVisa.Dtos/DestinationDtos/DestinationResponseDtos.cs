using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dtos.DestinationDtos
{
    public record DestinationCreateResponseDto(string Description, int Status);
    public record DestinationUpdateResponseDto(int Id, string Description);
	public record DestinationDeleteResponseDto(int Id);
	public record DestinationGetResponseDto(int Id, string Name, string Type, string Status);

}
