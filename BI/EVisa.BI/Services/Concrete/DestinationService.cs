using EVisa.BI.Services.Abstract;
using EVisa.Dal.Data.DalRepos;
using EVisa.Dal.Data.IDalRepos;
using EVisa.Dtos.DestinationDtos;
using EVisa.Entities.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using static EVisa.Dtos.CountryDtos.CountryResponseDtos;

namespace EVisa.BI.Services.Concrete
{
	public class DestinationService : IDestinationService
	{
		private readonly IDestinationRepository _destinationRepository;

		public DestinationService(IDestinationRepository destinationRepository)
		{
			_destinationRepository = destinationRepository;
		}

		public async Task<DestinationCreateResponseDto> Create(DestinationCreateRequestDtos model)
		{
			
				var destination = new Destination
				{
					Description = model.Description,
					//HomeCountryId = model.HomeCountryId,
					//ForeignCountryId = model.ForeignCountryId,
					 StatusAsString = model.Status
				};

				await _destinationRepository.InsertAsync(destination);
				 _destinationRepository.SaveChangesAsync();


				var responseData = destination.Adapt<DestinationCreateResponseDto>();

				return responseData;		
		}

		public async Task<DestinationDeleteResponseDto> DeleteAsync(DestinationDeleteRequestDtos model)
		{
			var deletedDestination = await _destinationRepository.GetAll().FirstOrDefaultAsync(x => x.Id == model.Id);
			if (deletedDestination != null) 
			{
				throw new Exception($"Ülke Id'si {model.Id} bulunamadı.");
			}

			await _destinationRepository.DeleteAsync(deletedDestination);
			_destinationRepository.SaveChangesAsync();

			return new DestinationDeleteResponseDto(deletedDestination.Id);

		}

		public async Task<List<DestinationGetResponseDto>> GetAll()
		{
			var datas = await _destinationRepository.GetAll().ToListAsync();
			var mappedData = datas.Adapt<List<DestinationGetResponseDto>>();

			return mappedData;
		}

		public async Task<DestinationUpdateResponseDto> UpdateAsync(DestinationUpdateRequestDtos model)
		{
			var updatedDestination = await _destinationRepository.GetAll().FirstOrDefaultAsync(x => x.Id == model.Id);

			updatedDestination.Id = model.Id;
			updatedDestination.Description = model.Description;

			var result = _destinationRepository.UpdateAsync(updatedDestination);
			var mappedData = _destinationRepository.Adapt<DestinationUpdateResponseDto>();

			return mappedData;

		}
	}
}
