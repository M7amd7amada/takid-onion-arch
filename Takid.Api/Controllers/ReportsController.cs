using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Takid.Application.Reports.Queries;
using Takid.Contracts.Reports;

namespace Takid.Api.Controllers;

[AllowAnonymous]
[Route("report")]
public class ReportsController(ISender mediator, IMapper mapper) : ApiController
{
    private readonly ISender _mediator = mediator;
    private readonly IMapper _mapper = mapper;

    [HttpGet]
    [Route("get")]
    public async Task<IActionResult> GetTopWorkingEmployees(TopWorkingEmployeesRequest request)
    {
        var query = _mapper.Map<TopWorkingEmployeesQuery>(request);
        var result = await _mediator.Send(query);

        return result.Match(
                res => Ok(_mapper.Map<TopWorkingEmployeesResult>(res)),
                errors => Problem(errors));
    }
}