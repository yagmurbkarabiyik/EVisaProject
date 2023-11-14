using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dtos.DestinationDtos
{
    /// <summary>
    /// create destination
    /// </summary>
    public class DestinationCreateRequestDtos
    {
        [DisplayName("Bölge Adı *")]
        public string Name { get; set; } = null!;

        [DisplayName("Ülke Adı *")]
        public string CountryId { get; set; } = null!;
    }

    public class CompanyCreateRequestValidator : AbstractValidator<DestinationCreateRequestDtos>
    {
        public CompanyCreateRequestValidator()
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

    /// <summary>
    /// update destination 
    /// </summary>
    public class DestinationUpdateRequestDtos
    {
        [DisplayName("Bölge Adı *")]
        public string Name { get; set; } = null!;

        [DisplayName("Ülke Adı *")]
        public string CountryId { get; set; } = null!;
    }

    public class CompanyUpdateRequestValidator : AbstractValidator<DestinationUpdateRequestDtos>
    {
        public CompanyUpdateRequestValidator()
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
