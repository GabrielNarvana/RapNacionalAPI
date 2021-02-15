using RapNacionalAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapNacionalAPI.Domain.Repositories
{
    public interface IAlbumRepository
    {
        public List<dynamic> GetAll();
        public int Insert(Album album);
    }
}
