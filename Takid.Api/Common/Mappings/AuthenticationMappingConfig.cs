using Takid.Application.Authentication.Common;
using Takid.Contracts.Authentication;
using Mapster;
using Takid.Domain.Users.ValueObjects;

namespace Takid.Api.Common.Mappings;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest.Token, src => src.Token)
            .Map(dest => dest, src => src.User)
            .Map(dest => dest.Id, src => UserId.Create(src.User.Id.Value));
    }
}