using RapNacionalAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapNacionalAPI.Domain.Repositories
{
    public interface IArtistaRepository
    {
        public List<Artista> GetAll();
        public Artista GetById(int Id);
        public Artista Insert(Artista artista);
    }
}
