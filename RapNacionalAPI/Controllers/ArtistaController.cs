using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RapNacionalAPI.Domain.Models;
using RapNacionalAPI.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RapNacionalAPI.Controllers
{
    [ApiController]
    public class ArtistaController : ControllerBase
    {
        private readonly IArtistaRepository _artistaRepository;

        public ArtistaController(IArtistaRepository artistaRepository)
        {
            _artistaRepository = artistaRepository;
            
        }

        [HttpGet("artista/all")]
        public ActionResult<IEnumerable<Artista>> GetAll()
        {
            var data = _artistaRepository.GetAll();
            return data;
        }

        [HttpGet("artista/{Id}")]
        public ActionResult<Artista> GetByID([FromQuery] int Id)
        {
            var data = _artistaRepository.GetById(Id);
            return data;
        }

        [HttpPost("artista/{Id}")]
        public ActionResult<Artista> Insert([FromBody] JsonElement Artista)
        {
            Artista artista = new Artista();
            var data = _artistaRepository.Insert(artista);
            return null;
        }

    }
}
