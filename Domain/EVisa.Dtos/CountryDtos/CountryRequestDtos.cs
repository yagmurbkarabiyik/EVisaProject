using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dtos.CountryDtos
{
    public class CountryCreateRequestDtos
    {
        [DisplayName("Ülke Adı *")]
        public string Name { get; set; } = null!;

        [DisplayName("Başvuru Türü*")]
        public string ApplicationType { get; set; } = null!;
    }

    public class CompanyCreateRequestValidator : AbstractValidator<CountryCreateRequestDtos>
    {
        public CompanyCreateRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Bu alan gereklidir")
                .NotEmpty().WithMessage("Bu alan gereklidir")
                .WithName("Ülke Adı");
            RuleFor(x => x.ApplicationType)
                .NotNull().WithMessage("Bu alan gereklidir")
                .NotEmpty().WithMessage("Bu alan gereklidir")
                .WithName("Başvuru Türü");

        }
    }

    /// <summary>
    /// update country request
    /// </summary>
    public class CountryUpdateRequestDtos
    {
        [DisplayName("Ülke Adı *")]
        public string Name { get; set; } = null!;

        [DisplayName("Başvuru Türü*")]
        public string ApplicationType { get; set; } = null!;
    }


    public class CompanyUpdateRequestValidator : AbstractValidator<CountryUpdateRequestDtos>
    {
        public CompanyUpdateRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Bu alan gereklidir")
                .NotEmpty().WithMessage("Bu alan gereklidir")
                .WithName("Ülke Adı");
            RuleFor(x => x.ApplicationType)
                .NotNull().WithMessage("Bu alan gereklidir")
                .NotEmpty().WithMessage("Bu alan gereklidir")
                .WithName("Başvuru Türü");
        }
    }
}
