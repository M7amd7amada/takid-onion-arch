using Takid.Domain.Reports;

namespace Takid.Application.Reports.Queries;

public record TopWorkingEmployeesResult(
    IEnumerable<WorkingEmployees> WorkingEmployees
);

public record TopWorkingSupervisorsResult(
    IEnumerable<WorkingSupervisors> WorkingSupervisors
);

public record TopProductiveEmployeesResult(
    IEnumerable<ProductiveEmployees> ProductiveEmployees
);