using RapNacionalAPI.Data.Context;
using RapNacionalAPI.Data.Model;
using RapNacionalAPI.Data.Repositories.Interfaces;

namespace RapNacionalAPI.Data.Repositories
{
    public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(MainDBContext context) : base(context)
        {
        }

        public IEnumerable<Album> GetPopularAlbuns(int count)
        {
            throw new NotImplementedException();
        }
    }
}
