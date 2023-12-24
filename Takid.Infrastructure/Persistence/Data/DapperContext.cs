using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Takid.Api.Data;

public class DapperContext : IDapperContext
{
    private readonly IConfiguration _configuration;
    private readonly string _connectionString;
    public DapperContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("SqlServer")!;
    }
    public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
}