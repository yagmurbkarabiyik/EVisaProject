using EVisa.Dtos.ApplicationTypeDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EVisa.Dtos.CountryDtos.CountryResponseDtos;

namespace EVisa.BI.Services.Abstract
{
	public interface IApplicationTypeService
	{
		Task<ApplicationTypeCreateResponseDto> Create(ApplicationTypeCreateRequestDtos model);
		Task<ApplicationTypeUpdateResponseDto> Update(ApplicationTypeUpdateRequestDtos model);
		Task<ApplicationTypeDeleteResponseDto> Delete(ApplicationTypeDeleteRequestDtos model);
		Task<List<GetApplicationTypeResponseDto>> GetAll();


	}
}
