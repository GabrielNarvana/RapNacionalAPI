using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using RapNacionalAPI.Data.Model;
using RapNacionalAPI.Services.Interfaces;

namespace RapNacionalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicaController : ControllerBase
    {
        private readonly ILogger<MusicaController> _logger;
        private readonly IMusicaService _musicaService;

        public MusicaController(ILogger<MusicaController> logger, IMusicaService musicaService)
        {
            _logger = logger;
            _musicaService = musicaService;
        }

        //[HttpGet(Name = "musica/all")]
        //public Album GetAll()
        //{
        //}
    }
}
