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
		[DisplayName("Açıklama *")]
		public string Description { get; set; } = null!;
		[DisplayName("Yabancı Ülke ID *")]
		//public int ForeignCountryId { get; set; }
		//[DisplayName("Home Ülke ID *")]
		//public int HomeCountryId { get; set; }
		//[DisplayName("Status *")]
		public string Status { get; set; } = null!;

	}

    public class DestinationCreateRequestValidator : AbstractValidator<DestinationCreateRequestDtos>
    {
        public DestinationCreateRequestValidator()
        {
			RuleFor(x => x.Description)
			  .NotNull().WithMessage("Bu alan gereklidir")
			  .NotEmpty().WithMessage("Bu alan gereklidir")
			  .WithName("Açıklama");
			//RuleFor(x => x.ForeignCountryId)
			//  .NotNull().WithMessage("Bu alan gereklidir")
			//  .NotEmpty().WithMessage("Bu alan gereklidir")
			//  .WithName("Yabancı Ülke ID");
			//RuleFor(x => x.HomeCountryId)
			//  .NotNull().WithMessage("Bu alan gereklidir")
			//  .NotEmpty().WithMessage("Bu alan gereklidir")
			//  .WithName("Home Ülke ID");
			RuleFor(x => x.Status)
			  .NotNull().WithMessage("Bu alan gereklidir")
			  .NotEmpty().WithMessage("Bu alan gereklidir")
			  .WithName("Status");

		}
    }

    /// <summary>
    /// update destination 
    /// </summary>
    public class DestinationUpdateRequestDtos
    {
		[DisplayName("ID")]
		public int Id { get; set; }
		[DisplayName("Açıklama *")]
		public string Description { get; set; } = null!;
	}

    public class DestinationUpdateRequestValidator : AbstractValidator<DestinationUpdateRequestDtos>
    {
        public DestinationUpdateRequestValidator()
        {
			RuleFor(x => x.Id)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("Açıklama");
			RuleFor(x => x.Description)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("Açıklama");
		}
    }

	/// <summary>
	/// delete destination 
	/// </summary>
	public class DestinationDeleteRequestDtos
	{
		[DisplayName("ID *")]
		public int Id { get; set; } 

	}

	public class DestinationDeleteRequestValidator : AbstractValidator<DestinationDeleteRequestDtos>
	{
		public DestinationDeleteRequestValidator()
		{
			RuleFor(x => x.Id).NotNull()
				.WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("ID");
		}
	}

}
