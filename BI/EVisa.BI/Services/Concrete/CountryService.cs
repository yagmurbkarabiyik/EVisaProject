using AutoMapper;
using EVisa.BI.Services.Abstract;
using EVisa.Dal.Data.IDalRepos;
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

        public Task<CountryCreateResponseDto> Create(CountryCreateResponseDto model)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CountryGetResponseDto>> GetAll()
        {
            var datas = await _countryRepository.GetAll().ToListAsync();
            var mappedData = datas.Adapt<List<CountryGetResponseDto>>();

            return mappedData;
        }

        public Task<CountryUpdateResponseDto> Update(CountryUpdateResponseDto model)
        {
            throw new NotImplementedException();
        }
    }
}
