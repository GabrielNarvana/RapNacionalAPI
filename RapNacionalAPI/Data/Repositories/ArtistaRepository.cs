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
            var query = Task.Run(() => ReadResource("GetAllAlbuns")).Result;

            return null;
        }

        public Artista GetById(int Id)
        {
            using SqlConnection connection = _sqlConnection.CreateCommand();

            var data = connection.Execute("Select * from Albuns where Id = @Id", Id);

            Artista SendArtista = new Artista
            { Nome = data.GetType().GetProperty("Nome").ToString(),
                Id = Int32.Parse(data.GetType().GetProperty("Id").ToString())
            };

            return SendArtista;
        }

        public int Insert(Artista artista)
        {
            using SqlConnection connection = _sqlConnection.CreateCommand();

            var query = "insert into albuns (album) values (@album)";

            var result = connection.Execute(query, new { artista = artista });

            return result;
        }
    }
}
