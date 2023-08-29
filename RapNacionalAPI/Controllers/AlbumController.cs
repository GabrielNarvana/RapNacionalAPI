using Microsoft.AspNetCore.Mvc;
using RapNacionalAPI.Data.Model;

namespace RapNacionalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {

        private readonly ILogger<AlbumController> _logger;

        public AlbumController(ILogger<AlbumController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "artista/all")]
        public Album GetAll()
        {
            return new Album();
        }
    }
}