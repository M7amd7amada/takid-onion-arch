using ErrorOr;
using MediatR;
using Takid.Application.Common.Interfaces.Persistance;
using Takid.Domain.Common.Errors;

namespace Takid.Application.Reports.Queries;

public class TopWorkingEmployeesQueryHandler(IReportRepository reportRepository)
    : IRequestHandler<TopWorkingEmployeesQuery, ErrorOr<TopWorkingEmployeesResult>>
{
    private readonly IReportRepository _reportRepository = reportRepository;

    public async Task<ErrorOr<TopWorkingEmployeesResult>> Handle(
        TopWorkingEmployeesQuery request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var workingEmployees = await _reportRepository.GetTop5WorkingEmployees(request.CompanyId);

        if (workingEmployees is null)
        {
            return Errors.Report.NotFound;
        }

        return new TopWorkingEmployeesResult(workingEmployees);
    }
}