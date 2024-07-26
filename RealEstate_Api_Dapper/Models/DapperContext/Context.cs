using Microsoft.Data.SqlClient;
using System.Data;

namespace RealEstate_Api_Dapper.Models.DapperContext
{
    public class Context
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString
                ("cconnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

       
    }
}
