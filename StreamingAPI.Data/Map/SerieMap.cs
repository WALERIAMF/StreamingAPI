using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreamingAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingAPI.Data.Map
{
    public class SerieMap : IEntityTypeConfiguration<Serie>
    {

 
        public void Configure(EntityTypeBuilder<Serie> builder)
        {
            builder.ToTable("Série");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Year)
                .HasColumnType("varchar(4)")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("varchar(800)");

            builder.Property(x => x.Seasons);

            builder.Property(x => x.Excluded)
                .IsRequired();
        }
    }
}
