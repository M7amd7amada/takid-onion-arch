using Takid.Application.Common.Interfaces.Services;

namespace Takid.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}