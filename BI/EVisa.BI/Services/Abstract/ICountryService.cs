using EVisa.Dtos.CountryDtos;
using static EVisa.Dtos.CountryDtos.CountryResponseDtos;

namespace EVisa.BI.Services.Abstract
{
    public interface ICountryService
    {
        Task<CountryCreateResponseDto> Create(CountryCreateRequestDtos model);
        Task<CountryUpdateResponseDto> UpdateAsync(CountryUpdateRequestDtos model);        
        Task<CountryDeleteResponseDto> DeleteAsync(CountryDeleteRequestDtos model);        
        Task<List<CountryGetResponseDto>> GetAll();
    }
}
