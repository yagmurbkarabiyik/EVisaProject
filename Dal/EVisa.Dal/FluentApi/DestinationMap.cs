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
    public class DestinationMap : IEntityTypeConfiguration<Destination>
    {
        public void Configure(EntityTypeBuilder<Destination> builder)
        {
            builder.ToTable("Destinations");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).HasMaxLength(300).IsRequired();
            //builder.Property(x => x.ForeignCountryId).IsRequired();
            //builder.Property(x => x.HomeCountryId).IsRequired();
            builder.Property(x => x.Status).IsRequired();

			// Destination - Country Relation
			builder.HasOne(x => x.Country)
                   .WithMany(x => x.Destinations)
                   .HasForeignKey(x => x.ForeignCountryId);

           // Destinaiton - Home Country Relation
             builder.HasOne(x => x.Country)
                   .WithMany(x => x.Destinations)
                   .HasForeignKey(x => x.HomeCountryId);

        }
    }
}
