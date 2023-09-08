using RapNacionalAPI.Data.Model;

namespace RapNacionalAPI.Data.Repositories.Interfaces
{
    public interface IAlbumRepository : IGenericRepository<Album>
    {
        IEnumerable<Album> GetPopularAlbuns(int count);

    }
}
