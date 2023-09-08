using Microsoft.AspNetCore.Mvc;
using RapNacionalAPI.Data.Model;
using RapNacionalAPI.Data.UnitOfWorks;
using RapNacionalAPI.Data.UnitOfWorks.Interfaces;

namespace RapNacionalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AlbumController> _logger;

        public AlbumController(IUnitOfWork unitOfWork, ILogger<AlbumController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet(Name = "artista/all")]
        public Album GetAll()
        {
        }
    }
}