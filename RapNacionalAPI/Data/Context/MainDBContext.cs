
using Microsoft.EntityFrameworkCore;
using RapNacionalAPI.Data.Model;
using System.Diagnostics;

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

    }
}
