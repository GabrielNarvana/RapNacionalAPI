using RapNacionalAPI.Data.Context;
using RapNacionalAPI.Data.Model;
using RapNacionalAPI.Data.Repositories.Interfaces;

namespace RapNacionalAPI.Data.Repositories
{
    public class ArtistaRepository : GenericRepository<Artista>, IArtistaRepository
    {
        public ArtistaRepository(MainDBContext context) : base(context)
        {
        }
    }
}
