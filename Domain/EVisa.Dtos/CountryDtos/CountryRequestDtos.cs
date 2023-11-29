using FluentValidation;
using System.ComponentModel;


namespace EVisa.Dtos.CountryDtos
{
    public class CountryCreateRequestDtos
    {
        [DisplayName("Ülke Adı *")]
        public string Name { get; set; } = null!;
		[DisplayName("Tür Adı *")]
		public string Type { get; set; } = null!;
		[DisplayName("Durum *")]
		public string Status { get; set; } = null!;

		//[DisplayName("Başvuru Türü*")]
		//public string ApplicationType { get; set; } = null!;
	}

    public class CountryCreateRequestValidator : AbstractValidator<CountryCreateRequestDtos>
    {
        public CountryCreateRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Bu alan gereklidir")
                .NotEmpty().WithMessage("Bu alan gereklidir")
                .WithName("Ülke Adı");
			RuleFor(x => x.Type)
			  .NotNull().WithMessage("Bu alan gereklidir")
			  .NotEmpty().WithMessage("Bu alan gereklidir")
			  .WithName("Tür Adı");
			RuleFor(x => x.Status)
	          .NotNull().WithMessage("Bu alan gereklidir")
	          .NotEmpty().WithMessage("Bu alan gereklidir")
	          .WithName("Durum ");
			//RuleFor(x => x.ApplicationType)
			//    .NotNull().WithMessage("Bu alan gereklidir")
			//    .NotEmpty().WithMessage("Bu alan gereklidir")
			//   .WithName("Başvuru Türü");

		}
    }

    /// <summary>
    /// update country request
    /// </summary>
    public class CountryUpdateRequestDtos
    {
		[DisplayName("ID *")]
		public int Id { get; set; }
		[DisplayName("Ülke Adı *")]
		public string Name { get; set; } = null!;
		[DisplayName("Tür Adı *")]
		public string Type { get; set; } = null!;
		[DisplayName("Durum *")]
		public string Status { get; set; } = null!;

	}

	public class CountryUpdateRequestValidator : AbstractValidator<CountryUpdateRequestDtos>
    {
        public CountryUpdateRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Bu alan gereklidir")
                .NotEmpty().WithMessage("Bu alan gereklidir")
                .WithName("Ülke Adı");
			RuleFor(x => x.Type)
			  .NotNull().WithMessage("Bu alan gereklidir")
			  .NotEmpty().WithMessage("Bu alan gereklidir")
			  .WithName("Tür Adı");
			RuleFor(x => x.Status)
			  .NotNull().WithMessage("Bu alan gereklidir")
			  .NotEmpty().WithMessage("Bu alan gereklidir")
			  .WithName("Durum");
			//RuleFor(x => x.ApplicationType)
			//    .NotNull().WithMessage("Bu alan gereklidir")
			//    .NotEmpty().WithMessage("Bu alan gereklidir")
			//    .WithName("Başvuru Türü");
		}
    }

	/// <summary>
	/// delete country request
	/// </summary>
	public class CountryDeleteRequestDtos
	{
		[DisplayName("ID *")]
		public int Id { get; set; }
	}

	public class CountryDeleteRequestValidator : AbstractValidator<CountryDeleteRequestDtos>
	{
		public CountryDeleteRequestValidator()
		{
			RuleFor(x => x.Id)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("ID");
		
		}
	}
}
