using EVisa.BI.Services.Abstract;
using EVisa.BI.Services.Concrete;
using EVisa.Dal.Data.DalRepos;
using EVisa.Dal.Data.IDalRepos;
using EVisa.Dtos.ApplicationTypeDtos;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static EVisa.Dtos.CountryDtos.CountryResponseDtos;

namespace EVisa.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ApplicationTypesController : ControllerBase
	{
		private readonly IApplicationTypeService _applicationTypeService;
		private readonly IApplicationTypeRepository _applicationTypeRepository;
		public ApplicationTypesController(IApplicationTypeService applicationTypeService, IApplicationTypeRepository applicationTypeRepository)
		{
			_applicationTypeService = applicationTypeService;
			_applicationTypeRepository = applicationTypeRepository;
		}

		[HttpGet("GetApplicationType")]
		public async Task<IActionResult> GetApplicationType()
		{
			var applicationType = await _applicationTypeService.GetAll();
			return Ok(applicationType);
		}

		[HttpPost("Insert")]
		public async Task<IActionResult> Insert(ApplicationTypeCreateRequestDtos model)
		{
			var applicationType = await _applicationTypeService.Create(model);

			_applicationTypeRepository.SaveChangesAsync();

			return Ok(model);
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAsync(ApplicationTypeUpdateRequestDtos model)
		{
			var applicationType = await _applicationTypeService.Update(model);
			_applicationTypeRepository.SaveChangesAsync();
			return Ok(model);
		}

		[HttpDelete]
		public async Task<IActionResult> DeleteAsync(int id)
		{
			var result = _applicationTypeRepository.GetAll().FirstOrDefault(x => x.Id == id);
			await _applicationTypeRepository.DeleteAsync(result);
			_applicationTypeRepository.SaveChangesAsync();

			return Ok(result);
		}
	}
}
