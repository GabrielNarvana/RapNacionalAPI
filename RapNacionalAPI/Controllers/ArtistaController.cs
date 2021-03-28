using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RapNacionalAPI.Domain.Models;
using RapNacionalAPI.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapNacionalAPI.Controllers
{
    [ApiController]
    public class ArtistaController : ControllerBase
    {
        private readonly ILogger<ArtistaController> _logger;
        private readonly IArtistaRepository _artistaRepository;

        public ArtistaController(ILogger<ArtistaController> logger, IArtistaRepository artistaRepository)
        {
            _logger = logger;
            _artistaRepository = artistaRepository;
            
        }

        [HttpGet("artista/all")]
        public ActionResult<IEnumerable<Artista>> GetAll()
        {
            var data = _artistaRepository.GetAll();
            return data;
        }

        [HttpGet("artista/{Id}")]
        public ActionResult<Artista> GetByID(int Id)
        {
            var data = _artistaRepository.GetById(Id);
            return data;
        }

    }
}
