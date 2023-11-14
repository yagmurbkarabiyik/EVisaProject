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
            builder.Property(x => x.ProcessingTime).IsRequired();
            builder.Property(x => x.DurationOfStay).IsRequired();
            builder.Property(at => at.VisaValidity).IsRequired();
            builder.Property(at => at.Price).IsRequired();

        }
    }
}
