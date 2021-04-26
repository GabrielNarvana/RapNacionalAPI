using Dapper;
using Microsoft.Extensions.Configuration;
using RapNacionalAPI.Domain.Models;
using RapNacionalAPI.Infra;
using RapNacionalAPI.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RapNacionalAPI.Domain.Repositories
{
    public class ArtistaRepository : DatabaseReaderFile, IArtistaRepository
    {
        private readonly ISQLConnection _sqlConnection;
        private readonly IConfiguration _configuration;

        public ArtistaRepository(ISQLConnection SqlConnection, IConfiguration configuration)
        {
            _sqlConnection = SqlConnection;
            _configuration = configuration;
        }

        public List<Artista> GetAll()
        {
            using SqlConnection connection = _sqlConnection.CreateCommand();
            var query = Task.Run(() => ReadResource("GetAllArtistas")).Result;

            return null;
        }

        public Artista GetById(int Id)
        {
            using SqlConnection connection = _sqlConnection.CreateCommand();
            var query = Task.Run(() => ReadResource("GetArtistasById")).Result;

            return null;
        }

        public Artista Insert(Artista artista)
        {
            using SqlConnection connection = _sqlConnection.CreateCommand();
            var query = Task.Run(() => ReadResource("GetArtistasById")).Result;
            var result = connection.Execute(query, new { artista = artista });

            return null;
        }
    }
}
