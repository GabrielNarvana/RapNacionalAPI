using Microsoft.EntityFrameworkCore;
using RapNacionalAPI.Data.Context;
using RapNacionalAPI.Data.Model;
using RapNacionalAPI.Data.Repositories;
using RapNacionalAPI.Data.Repositories.Interfaces;
using RapNacionalAPI.Data.UnitOfWorks.Interfaces;

namespace RapNacionalAPI.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MainDBContext _context;

        public UnitOfWork(MainDBContext context)
        {
            _context = context;
            Album = new AlbumRepository(_context);
            Artista = new GenericRepository<Artista>(_context);
            Musica = new GenericRepository<Musica>(_context);

        }

        public IAlbumRepository Album { get; private set; }
        public IGenericRepository<Artista> Artista { get; private set; }
        public IGenericRepository<Musica> Musica { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
