using Dapper;
using Microsoft.Extensions.Configuration;
using RapNacionalAPI.Domain.Models;
using RapNacionalAPI.Helpers;
using RapNacionalAPI.Infra;
using RapNacionalAPI.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
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
            try
            {
                using SqlConnection connection = _sqlConnection.CreateCommand();
                var query = Task.Run(() => ReadResource("GetAllArtistas")).Result;
                return null;
            }
            catch (Exception ex)
            {
                LoggerHelper.LogFile(ex, Process.GetCurrentProcess().ProcessName);
                throw ex;
            }
        }

        public Artista GetById(int Id)
        {
            try
            {
                using SqlConnection connection = _sqlConnection.CreateCommand();
                var query = Task.Run(() => ReadResource("GetArtistasById")).Result;
                return null;
            }
            catch (Exception ex)
            {
                LoggerHelper.LogFile(ex, Process.GetCurrentProcess().ProcessName);
                throw ex;
            }
        }

        public Artista Insert(Artista artista)
        {
                try
                {
                    using SqlConnection connection = _sqlConnection.CreateCommand();
                    var query = Task.Run(() => ReadResource("GetArtistasById")).Result;
                    var result = connection.Execute(query, new { artista = artista });
                    return null;
                }
                catch (Exception ex)
                {
                    LoggerHelper.LogFile(ex, Process.GetCurrentProcess().ProcessName);
                    throw ex;
                }
        }
    }
}
