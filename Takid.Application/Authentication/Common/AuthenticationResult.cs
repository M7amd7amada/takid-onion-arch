using Takid.Domain.Users;

namespace Takid.Application.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token);