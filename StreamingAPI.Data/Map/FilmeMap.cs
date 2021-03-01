using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreamingAPI.Domain.Model;

namespace StreamingAPI.Data.Map
{
    public class FilmeMap : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.ToTable("Filme");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Year)
                .HasColumnType("varchar(4)")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("varchar(800)");

            builder.Property(x => x.Excluded)
                .IsRequired();

        }
    }
}
