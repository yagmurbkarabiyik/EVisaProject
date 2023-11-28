using EVisa.Dtos.CountryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EVisa.Dtos.CountryDtos.CountryResponseDtos;

namespace EVisa.BI.Services.Abstract
{
    public interface ICountryService
    {
        Task<CountryCreateResponseDto> Create(CountryCreateRequestDtos model);
        Task<CountryUpdateResponseDto> UpdateAsync(CountryUpdateRequestDtos model);        
        Task<List<CountryGetResponseDto>> GetAll();
    }
}
