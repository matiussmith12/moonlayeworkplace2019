using SqlKata;
using SqlKata.Compilers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.WebApp.Services
{
    public interface IEWorkConnection
    {
        SqlConnection Connection { get; }
        SqlServerCompiler Compiler { get; }

        Query Query(string table);
    }
}
