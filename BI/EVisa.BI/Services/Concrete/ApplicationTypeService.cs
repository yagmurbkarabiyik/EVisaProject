using EVisa.BI.Services.Abstract;
using EVisa.Dal.Data.DalRepos;
using EVisa.Dal.Data.IDalRepos;
using EVisa.Dtos.ApplicationTypeDtos;
using EVisa.Entities.Models;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EVisa.Dtos.CountryDtos.CountryResponseDtos;

namespace EVisa.BI.Services.Concrete
{
	public class ApplicationTypeService : IApplicationTypeService
	{
		private readonly IApplicationTypeRepository _applicationTypeRepository;

		public ApplicationTypeService(IApplicationTypeRepository applicationTypeRepository)
		{
			_applicationTypeRepository = applicationTypeRepository;
		}

		public async Task<ApplicationTypeCreateResponseDto> Create(ApplicationTypeCreateRequestDtos model)
		{
			{
				var applicationType = new ApplicationType
				{
					Name = model.Name,
					CountryId = model.CountryId,
					DurationOfStay = model.DurationOfStay,	
					EntryType= model.EntryType,	
					Price= model.Price,	
					VisaValidity= model.VisaValidity,
					ProcessingTime= model.ProcessingTime,
					StatusAsString = model.Status
				};
				await _applicationTypeRepository.InsertAsync(applicationType);

				var responseData = applicationType.Adapt<ApplicationTypeCreateResponseDto>();
				return responseData;
			}
		}

		public async Task<ApplicationTypeDeleteResponseDto> Delete(ApplicationTypeDeleteRequestDtos model)
		{
			var applicationType =  _applicationTypeRepository.GetAll().FirstOrDefault(x => x.Id == model.Id );
			if (applicationType != null)
			{
				throw new Exception($"Başvuru Türü Id'si {model.Id} bulunamadı.");
			}

			await _applicationTypeRepository.DeleteAsync(applicationType);
			_applicationTypeRepository.SaveChangesAsync();

			return new ApplicationTypeDeleteResponseDto(applicationType.Id);

		}

		public async Task<List<GetApplicationTypeResponseDto>> GetAll()
		{
			var datas = await _applicationTypeRepository.GetAll().ToListAsync();
			var mappedData = datas.Adapt<List<GetApplicationTypeResponseDto>>();

			return mappedData;
		}

		public async Task<ApplicationTypeUpdateResponseDto> Update(ApplicationTypeUpdateRequestDtos model)
		{
			var applicationType = await _applicationTypeRepository.GetAll().FirstOrDefaultAsync(c => c.Id == model.Id);

			applicationType.CountryId = model.CountryId;
			applicationType.VisaValidity = model.VisaValidity;
			applicationType.Price = model.Price;
			applicationType.ProcessingTime = model.ProcessingTime;
			applicationType.DurationOfStay = model.DurationOfStay;
			applicationType.Name = model.Name;

			var result = _applicationTypeRepository.UpdateAsync(applicationType);
			var mappedData = _applicationTypeRepository.Adapt<ApplicationTypeUpdateResponseDto>();

			return mappedData;
		}
	}
}
