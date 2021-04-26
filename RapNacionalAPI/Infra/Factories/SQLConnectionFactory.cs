using RapNacionalAPI.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RapNacionalAPI.Infra.Factories
{
    public class SQLConnectionFactory : ISQLConnection
    {
        private readonly string _connectionString;

        public SQLConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public SqlConnection CreateCommand()
        {
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}
