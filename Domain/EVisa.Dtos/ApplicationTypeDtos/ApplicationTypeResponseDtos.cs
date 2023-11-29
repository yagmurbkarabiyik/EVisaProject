using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dtos.ApplicationTypeDtos
{
    public record ApplicationTypeCreateResponseDto(int Id, int EntryType, int CountryId, int ProcessingTime, int DurationOfStay,  int VisaValidity, int Price, string Status);
    public record ApplicationTypeUpdateResponseDto(int Id, int CountryId, int ProcessingTime, int DurationOfStay, int VisaValidity, int Price);
    public record ApplicationTypeDeleteResponseDto(int Id);
    public record GetApplicationTypeResponseDto(int Id, int CountryId);
}
