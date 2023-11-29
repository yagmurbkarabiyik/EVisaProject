using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dtos.ApplicationTypeDtos
{
    public class ApplicationTypeCreateRequestDtos
	{
		[DisplayName("Giriş Türü *")]
		public int EntryType { get; set; } 
		public int CountryId { get; set; }
		[DisplayName("İşlem Süresi *")]
        public int ProcessingTime { get; set; } 
		[DisplayName("Vize Geçerlilik Süresi *")] 
        public int VisaValidity { get; set; }
		[DisplayName("Kalış Süresi *")]
		public int DurationOfStay { get; set; }

		[DisplayName("Fiyat")]
        public int Price { get; set; }
		[DisplayName("Status")]
		public string Status { get; set; }
		[DisplayName("İsim")]
		public string Name { get; set; }
		//[DisplayName("Status")]
		//public int StatusAsString { get; set; }
	}
	public class ApplicationTypeCreateRequestValidator : AbstractValidator<ApplicationTypeCreateRequestDtos>
    {
        public ApplicationTypeCreateRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Bu alan gereklidir")
                .NotEmpty().WithMessage("Bu alan gereklidir")
                .WithName("Bölge Adı");
            RuleFor(x => x.CountryId)
                .NotNull().WithMessage("Bu alan gereklidir")
                .NotEmpty().WithMessage("Bu alan gereklidir")
                .WithName("Ülke Adı");
			RuleFor(x => x.VisaValidity)
			   .NotNull().WithMessage("Bu alan gereklidir")
			   .NotEmpty().WithMessage("Bu alan gereklidir")
			   .WithName("Vize Geçerliliği");
			RuleFor(x => x.Price)
			   .NotNull().WithMessage("Bu alan gereklidir")
			   .NotEmpty().WithMessage("Bu alan gereklidir")
			   .WithName("Fiyat");
			RuleFor(x => x.EntryType)
			   .NotNull().WithMessage("Bu alan gereklidir")
			   .NotEmpty().WithMessage("Bu alan gereklidir")
			   .WithName("Giriş Türü");
			RuleFor(x => x.DurationOfStay)
			  .NotNull().WithMessage("Bu alan gereklidir")
			   .NotEmpty().WithMessage("Bu alan gereklidir")
			  .WithName("Giriş Türü");
			RuleFor(x => x.ProcessingTime)
			  .NotNull().WithMessage("Bu alan gereklidir")
			   .NotEmpty().WithMessage("Bu alan gereklidir")
			  .WithName("İşlem Süresi");
		}
    }
	public class ApplicationTypeUpdateRequestDtos
	{
		[DisplayName("Başvuru Türü *")]
		public int Id { get; set; }
		[DisplayName("Başvuru Türü *")]
		public string Name { get; set; } 

		[DisplayName("Kalış Süresi *")]
		public int CountryId { get; set; } 

		[DisplayName("Vize Geçerliliği")]
		public int VisaValidity { get; set; } 

		[DisplayName("Fiyat")]
		public int Price { get; set; }
		[DisplayName("İşlem Süresi")]
		public int ProcessingTime { get; set; }
		[DisplayName("Kalış Süresi")]
		public int DurationOfStay { get; set; }

	}
	public class ApplicationTypeUpdateRequestValidator : AbstractValidator<ApplicationTypeUpdateRequestDtos>
	{
		public ApplicationTypeUpdateRequestValidator()
		{
			RuleFor(x => x.Id)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("ID");
			RuleFor(x => x.Name)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("Bölge Adı");
			RuleFor(x => x.CountryId)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("Ülke Adı");
			RuleFor(x => x.VisaValidity)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("Vize Geçerlilik Süresi");
			RuleFor(x => x.Price)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("Fiyat");
			RuleFor(x => x.CountryId)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("Ülke Adı");
			RuleFor(x => x.ProcessingTime)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("İşlem Süresi");
			RuleFor(x => x.DurationOfStay)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("Kalış Süresi");
		}
	}
	public class ApplicationTypeDeleteRequestDtos
	{
		[DisplayName("ID *")]
		public int Id { get; set; } 
	}
	public class ApplicationTypeDeleteRequestValidator : AbstractValidator<ApplicationTypeDeleteRequestDtos>
	{
		public ApplicationTypeDeleteRequestValidator()
		{
			RuleFor(x => x.Id)
				.NotNull().WithMessage("Bu alan gereklidir")
				.NotEmpty().WithMessage("Bu alan gereklidir")
				.WithName("ID");
		}
	}
}
