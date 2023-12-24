using ErrorOr;
using MediatR;
using Takid.Application.Common.Interfaces.Persistance;
using Takid.Domain.Common.Errors;

namespace Takid.Application.Reports.Queries;

public class TopWorkingSupervisorsQueryHandler(IReportRepository reportRepository)
    : IRequestHandler<TopWorkingSupervisorsQuery, ErrorOr<TopWorkingSupervisorsResult>>
{
    private readonly IReportRepository _reportRepository = reportRepository;

    public async Task<ErrorOr<TopWorkingSupervisorsResult>> Handle(
        TopWorkingSupervisorsQuery request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        var workingEmployees = await _reportRepository.GetTop5WorkingSupervisors(request.CompanyId);

        if (workingEmployees is null)
        {
            return Errors.Report.NotFound;
        }

        return new TopWorkingSupervisorsResult(workingEmployees);
    }
}