using RapNacionalAPI.Data.Model;
using RapNacionalAPI.Data.Repositories;
using RapNacionalAPI.Data.Repositories.Interfaces;

namespace RapNacionalAPI.Data.UnitOfWorks.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository Album { get; }
        IGenericRepository<Artista> Artista { get; }
        IGenericRepository<Musica> Musica { get; }

        int Complete();

    }
}
