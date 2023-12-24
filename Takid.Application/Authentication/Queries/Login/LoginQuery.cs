using Takid.Application.Authentication.Common;
using ErrorOr;
using MediatR;

namespace Takid.Application.Authentication.Queries.Login;

public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;