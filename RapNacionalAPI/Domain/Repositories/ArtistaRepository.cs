using Dapper;
using RapNacionalAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RapNacionalAPI.Domain.Repositories
{
    public class ArtistaRepository : IArtistaRepository
    {
        private readonly string _connectionString;

        public ArtistaRepository(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }

        public List<Artista> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            var data = connection.Query("Select * from Albuns").ToList();

            List<Artista> SendArtista = data.Select(x => new Artista 
            { Nome = x.Nome, Id = x.Id }
            ).ToList();

            return SendArtista;
        }

        public Artista GetById(int Id)
        {
            using var connection = new SqlConnection(_connectionString);

            var data = connection.Execute("Select * from Albuns where Id = @Id", Id);

            Artista SendArtista = new Artista
            { Nome = data.GetType().GetProperty("Nome").ToString(),
                Id = Int32.Parse(data.GetType().GetProperty("Id").ToString())
            };

            return SendArtista;
        }

        public int Insert(Artista artista)
        {
            using var connection = new SqlConnection(_connectionString);

            var query = "insert into albuns (album) values (@album)";

            var result = connection.Execute(query, new { artista = artista });

            return result;
        }
    }
}
