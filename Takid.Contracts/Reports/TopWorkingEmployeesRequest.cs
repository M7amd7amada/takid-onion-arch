namespace Takid.Contracts.Reports;

public record TopWorkingEmployeesRequest(
    int companyId,
    DateTime StartDate,
    DateTime EndDate
);