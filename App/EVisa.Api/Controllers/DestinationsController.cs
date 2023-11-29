using EVisa.BI.Services.Abstract;
using EVisa.BI.Services.Concrete;
using EVisa.Dal.Data.DalRepos;
using EVisa.Dal.Data.IDalRepos;
using EVisa.Dtos.DestinationDtos;
using Microsoft.AspNetCore.Mvc;

namespace EVisa.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DestinationsController : ControllerBase
	{
		private readonly IDestinationService _destinationService;
		private readonly IDestinationRepository _destinationRepository;

		public DestinationsController(IDestinationService destinationService, IDestinationRepository destinationRepository)
		{
			_destinationService = destinationService;
			_destinationRepository = destinationRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetDestination()
		{
			var destinations = await _destinationService.GetAll();
			return Ok(destinations);
		}

		[HttpPost]
		public async Task<IActionResult> Insert(DestinationCreateRequestDtos model)
		{
			var destination = await _destinationService.Create(model);

			//_destinationRepository.SaveChangesAsync();

			return Ok(model);

		}

		[HttpPut]
		public async Task<IActionResult> Update(DestinationUpdateRequestDtos model)
		{
			var updatedDestination = await _destinationService.UpdateAsync(model);
			_destinationRepository.SaveChangesAsync();
			return Ok(model);
		}

		[HttpDelete]
		public async Task<IActionResult> Delete(int id)
		{
			var result = _destinationRepository.GetAll().FirstOrDefault(x => x.Id == id);
			await _destinationRepository.DeleteAsync(result);
			_destinationRepository.SaveChangesAsync();	
			return Ok(result);
		}
	}
}
