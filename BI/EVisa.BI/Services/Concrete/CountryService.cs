using EVisa.BI.Services.Abstract;
using EVisa.Dal.Data.IDalRepos;
using EVisa.Dtos.CountryDtos;
using EVisa.Entities.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using static EVisa.Dtos.CountryDtos.CountryResponseDtos;

namespace EVisa.BI.Services.Concrete
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        public async Task<CountryCreateResponseDto> Create(CountryCreateRequestDtos model)
        {
            var country = new Country
            {
                Name = model.Name,
                Type = model.Type,
                StatusAsString= model.Status
  			};

            await _countryRepository.InsertAsync(country);

            var responseData = country.Adapt<CountryCreateResponseDto>();
            return responseData;

        }

        public async Task<List<CountryGetResponseDto>> GetAll()
        {
            var datas = await _countryRepository.GetAll().ToListAsync();
            var mappedData = datas.Adapt<List<CountryGetResponseDto>>();

            return mappedData;
        }

        public async Task<CountryUpdateResponseDto> Update(CountryUpdateRequestDtos model)
        {
            var datas = await _countryRepository.UpdateAsync(model);
        }
    }
}

//todo application type hata veriyor, create için responsedan application silinince 200 dönüyor ama swaggerda da country name null dönüyor, dbye gelmiyor