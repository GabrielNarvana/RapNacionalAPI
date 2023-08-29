
using Microsoft.EntityFrameworkCore;
using RapNacionalAPI.Data.Model;

namespace RapNacionalAPI.Data.Context
{
    public class MainDBContext : DbContext
    {
        public MainDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Album> Albuns { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>(c =>
            {
                c.Property(p => p.Capa).HasMaxLength(1000);
            });

            modelBuilder.Entity<Musica>(c =>
            {
                c.Property(p => p.Capa).HasMaxLength(1000);
            });
        }
    }
}
