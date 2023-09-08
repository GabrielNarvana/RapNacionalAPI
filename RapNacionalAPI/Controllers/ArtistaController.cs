using Microsoft.AspNetCore.Mvc;
using RapNacionalAPI.Data.Model;
using RapNacionalAPI.Services.Interfaces;

namespace RapNacionalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArtistaController : ControllerBase
    {
        private readonly ILogger<ArtistaController> _logger;
        private readonly IArtistaService _artistaService;
        public ArtistaController(ILogger<ArtistaController> logger, IArtistaService artistaService)
        {
            _logger = logger;
            _artistaService = artistaService;
        }

        //[HttpGet(Name = "artista/all")]
        //public Album GetAll()
        //{
        //}
    }
}
