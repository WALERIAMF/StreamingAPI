using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreamingAPI.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingAPI.Data.Map
{
    public class GenreMap : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Description)
                .HasColumnType("varchar(800)");

        }
    }
}
