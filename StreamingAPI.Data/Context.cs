using Microsoft.EntityFrameworkCore;
using StreamingAPI.Data.Map;
using StreamingAPI.Domain.Model;


namespace StreamingAPI.Data
{
    public class Context : DbContext
    {
        public DbSet<Film> Film { get; set; }
        public DbSet<Serie> Serie { get; set; }
        public DbSet<Genre> Genre { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0E2MGV9\\SQLEXPRESS; Database=streaming; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FilmeMap());
            modelBuilder.ApplyConfiguration(new SerieMap());
            modelBuilder.ApplyConfiguration(new GenreMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
