using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dtos.ApplicationTypeDtos
{
    public class DestinationCreateRequestDtos
    {
        [DisplayName("Başvuru Türü *")]
        public string Name { get; set; } = null!;

        [DisplayName("Kalış Süresi *")]
        public string CountryId { get; set; } = null!;

        [DisplayName("Vize Geçerliliği")]
        public string VisaValidity { get; set; } = null!;

        [DisplayName("Fiyat")]
        public string Price { get; set; } = null!;
    }

    public class CountryCreateRequestValidator : AbstractValidator<DestinationCreateRequestDtos>
    {
        public CountryCreateRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Bu alan gereklidir")
                .NotEmpty().WithMessage("Bu alan gereklidir")
                .WithName("Bölge Adı");

            RuleFor(x => x.CountryId)
                .NotNull().WithMessage("Bu alan gereklidir")
                .NotEmpty().WithMessage("Bu alan gereklidir")
                .WithName("Ülke Adı");

        }
    }
}
