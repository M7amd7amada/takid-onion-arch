using Takid.Domain.Reports;

namespace Takid.Application.Common.Interfaces.Persistance;

public interface IReportRepository
{
    public Task<IEnumerable<ProductiveEmployees>> GetTop5ProductiveEmployees(
        int companyId,
        DateTime startDate,
        DateTime endDate);
    public Task<IEnumerable<WorkingEmployees>> GetTop5WorkingEmployees(int companyId);
    public Task<IEnumerable<WorkingSupervisors>> GetTop5WorkingSupervisors(int companyId);
}