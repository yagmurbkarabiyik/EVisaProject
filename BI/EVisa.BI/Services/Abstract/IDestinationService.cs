using EVisa.Dtos.DestinationDtos;

namespace EVisa.BI.Services.Abstract
{
	public interface IDestinationService
	{
		Task<DestinationCreateResponseDto> Create(DestinationCreateRequestDtos model);
		Task<DestinationUpdateResponseDto> UpdateAsync(DestinationUpdateRequestDtos model);
		Task<DestinationDeleteResponseDto> DeleteAsync(DestinationDeleteRequestDtos model);
		Task<List<DestinationGetResponseDto>> GetAll();
	}
}
