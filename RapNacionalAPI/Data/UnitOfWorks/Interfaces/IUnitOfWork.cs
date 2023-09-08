using RapNacionalAPI.Data.Repositories.Interfaces;

namespace RapNacionalAPI.Data.UnitOfWorks.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository Album { get; }
        IArtistaRepository Artista { get; }
        IMusicaRepository Musica { get; }

        int Complete();

    }
}
