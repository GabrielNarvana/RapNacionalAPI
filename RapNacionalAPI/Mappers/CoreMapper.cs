using AutoMapper;
using RapNacionalAPI.Data.Model;
using RapNacionalAPI.DTOs.Response;

namespace RapNacionalAPI.Mappers
{
    public class CoreMapper : Profile
    {
        public CoreMapper() {
            album();
        }

        private void album()
        {
            CreateMap<Album, AlbumResponse>();
        }
    }
}
