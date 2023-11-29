using EVisa.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVisa.Dal.FluentApi
{
    public class ApplicationTypeMap : IEntityTypeConfiguration<ApplicationType>
    {
        public void Configure(EntityTypeBuilder<ApplicationType> builder)
        {
            builder.ToTable("ApplicationTypes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.EntryType).IsRequired();
			builder.Property(x => x.CountryId).IsRequired();
            builder.Property(x => x.ProcessingTime).IsRequired();
            builder.Property(x => x.DurationOfStay).IsRequired();
			builder.Property(x => x.VisaValidity).IsRequired();
			builder.Property(x => x.Price).IsRequired();
			builder.Property(x => x.Status).IsRequired();
			builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.StatusAsString).IsRequired();

        }
    }
}
