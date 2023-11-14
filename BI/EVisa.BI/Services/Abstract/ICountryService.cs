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
        Task<CountryCreateResponseDto> Create(CountryCreateResponseDto model);
        Task<CountryUpdateResponseDto> Update(CountryUpdateResponseDto model);
        Task<List<CountryGetResponseDto>> GetAll();
    }
}
