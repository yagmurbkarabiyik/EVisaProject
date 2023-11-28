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
                StatusAsString = model.Status
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

        public async Task<CountryUpdateResponseDto> UpdateAsync(CountryUpdateRequestDtos model)
        {
            var existingCountry = await _countryRepository.GetAll().FirstOrDefaultAsync(c => c.Id == model.Id) ;

			existingCountry.Name = model.Name;
			existingCountry.Type = model.Type;
			existingCountry.StatusAsString = model.Status;

			var result = _countryRepository.UpdateAsync(existingCountry);
			var mappedData = existingCountry.Adapt<CountryUpdateResponseDto>();
            return mappedData;
		}
	}
}