using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RapNacionalAPI.Infra.Interface
{
    public interface ISQLConnection
    {
        SqlConnection CreateCommand();
    }
}
