using System.Data;
using Dapper;
using Takid.Api.Data;
using Takid.Application.Common.Interfaces.Persistance;
using Takid.Domain.Reports;

namespace Takid.Infrastructure.Persistence.Repositories
{
    public class ReportRepository(IDapperContext context) : IReportRepository
    {
        private readonly IDapperContext _context = context;

        public async Task<IEnumerable<ProductiveEmployees>> GetTop5ProductiveEmployees(
            int companyId,
            DateTime startDate,
            DateTime endDate)
        {
            using IDbConnection connection = _context.CreateConnection();
            return await connection.QueryAsync<ProductiveEmployees>(
                "Get_Top_5_Productive_Employees",
                new
                {
                    company_id = companyId,
                    start_date = startDate,
                    end_date = endDate
                },
                commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<WorkingEmployees>> GetTop5WorkingEmployees(int companyId)
        {
            using IDbConnection connection = _context.CreateConnection();
            return await connection.QueryAsync<WorkingEmployees>(
                "Get_Top_5_Working_Employees",
                new { company_id = companyId },
                commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<WorkingSupervisors>> GetTop5WorkingSupervisors(int companyId)
        {
            using IDbConnection connection = _context.CreateConnection();
            return await connection.QueryAsync<WorkingSupervisors>(
                "Get_Top_5_Working_Supervisors",
                new { company_id = companyId },
                commandType: CommandType.StoredProcedure);
        }
    }
}