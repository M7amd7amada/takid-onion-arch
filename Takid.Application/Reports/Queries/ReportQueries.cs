using ErrorOr;
using MediatR;
using Takid.Domain.Reports;

namespace Takid.Application.Reports.Queries;

public record TopWorkingEmployeesQuery(
    int CompanyId
) : IRequest<ErrorOr<TopWorkingEmployeesResult>>;
public record TopWorkingSupervisorsQuery(
    int CompanyId
) : IRequest<ErrorOr<TopWorkingSupervisorsResult>>;

public record TopProductiveEmployeesQuery(
    int CompanyId,
    DateTime StartDate,
    DateTime EndDate
) : IRequest<ErrorOr<TopProductiveEmployeesResult>>;