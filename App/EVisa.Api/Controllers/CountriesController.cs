using EVisa.BI.Services.Abstract;
using EVisa.Dal.Data.IDalRepos;
using EVisa.Dtos.CountryDtos;
using EVisa.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using static EVisa.Dtos.CountryDtos.CountryResponseDtos;

namespace EVisa.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private readonly ICountryRepository _coutryRepository;

		public CountriesController(ICountryService countryService, ICountryRepository coutryRepository)
		{
			_countryService = countryService;
			_coutryRepository = coutryRepository;
		}

		[HttpGet]
        public async Task<IActionResult> GetCountry()
        {
            var country = await _countryService.GetAll();
            return Ok(country);

        }

        [HttpPost]
        public async Task<IActionResult> Insert(CountryCreateRequestDtos model)
		{
			var createdCountry = await _countryService.Create(model);

           _coutryRepository.SaveChangesAsync();

            return Ok(model);

		}

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(CountryUpdateRequestDtos model) 
        {
            var updatedCountry = await _countryService.UpdateAsync(model);
            _coutryRepository.SaveChangesAsync();
            return Ok(model);
        }

     

    }
}
