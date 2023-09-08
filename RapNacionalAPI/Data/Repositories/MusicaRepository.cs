using RapNacionalAPI.Data.Context;
using RapNacionalAPI.Data.Model;
using RapNacionalAPI.Data.Repositories.Interfaces;

namespace RapNacionalAPI.Data.Repositories
{
    public class MusicaRepository : GenericRepository<Musica>, IMusicaRepository
    {
        public MusicaRepository(MainDBContext context) : base(context)
        {
        }
    }
}
