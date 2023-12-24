using System.Data;

namespace Takid.Api.Data;

public interface IDapperContext
{
    public IDbConnection CreateConnection();
}