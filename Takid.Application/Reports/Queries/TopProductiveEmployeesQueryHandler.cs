using ErrorOr;
using MediatR;
using Takid.Application.Common.Interfaces.Persistance;
using Takid.Domain.Common.Errors;

namespace Takid.Application.Reports.Queries;
public class TopProductiveEmployeesQueryHandler(IReportRepository reportRepository)
    : IRequestHandler<TopProductiveEmployeesQuery, ErrorOr<TopProductiveEmployeesResult>>
{
    private readonly IReportRepository _reportRepository = reportRepository;

    public async Task<ErrorOr<TopProductiveEmployeesResult>> Handle(
        TopProductiveEmployeesQuery request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var workingEmployees = await _reportRepository.GetTop5ProductiveEmployees(
            request.CompanyId, request.StartDate, request.EndDate);

        if (workingEmployees is null)
        {
            return Errors.Report.NotFound;
        }

        return new TopProductiveEmployeesResult(workingEmployees);
    }
}