using Microsoft.AspNetCore.Mvc;
using RapNacionalAPI.Data.Model;
using RapNacionalAPI.Data.UnitOfWorks;
using RapNacionalAPI.Data.UnitOfWorks.Interfaces;
using RapNacionalAPI.DTOs.Response;
using RapNacionalAPI.Services.Interfaces;

namespace RapNacionalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly ILogger<AlbumController> _logger;
        private readonly IAlbumService _albumService;

        public AlbumController(ILogger<AlbumController> logger, IAlbumService albumService)
        {
            _logger = logger;
            _albumService = albumService;
        }

        [HttpGet(Name = "album/all")]
        public IEnumerable<AlbumResponse> GetAll()
        {
            return _albumService.GetAllAlbuns();
        }
    }
}