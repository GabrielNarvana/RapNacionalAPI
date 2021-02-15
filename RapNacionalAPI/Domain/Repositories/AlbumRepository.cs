using Dapper;
using RapNacionalAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RapNacionalAPI.Domain.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        private readonly string _connectionString;

        public AlbumRepository(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }

        public List<dynamic> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            var data = connection.Query("Select * from Albuns").ToList();
            return data;
        }

        public int Insert(Album album)
        {
            using var connection = new SqlConnection(_connectionString);

            var query = "insert into albuns (album) values (@album)";

            var result = connection.Execute(query, new { album = album });

            return result;
        }
    }
}
