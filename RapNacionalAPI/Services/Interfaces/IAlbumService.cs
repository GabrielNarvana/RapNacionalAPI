using RapNacionalAPI.Data.Model;
using RapNacionalAPI.DTOs.Response;

namespace RapNacionalAPI.Services.Interfaces
{
    public interface IAlbumService
    {
        IEnumerable<AlbumResponse> GetAllAlbuns();
    }
}
