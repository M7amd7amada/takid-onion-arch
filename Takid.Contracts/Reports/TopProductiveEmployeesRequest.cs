namespace Takid.Contracts.Reports;

public record TopProductiveEmployeesRequest(
    int CompanyId,
    DateTime StartDate,
    DateTime EndDate
);