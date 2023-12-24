using ErrorOr;

namespace Takid.Domain.Common.Errors;

public static partial class Errors
{
    public static class Report
    {
        public static Error NotFound => Error.NotFound(
            code: "Report.NotFound",
            description: "The desired report not found.");
    }
}