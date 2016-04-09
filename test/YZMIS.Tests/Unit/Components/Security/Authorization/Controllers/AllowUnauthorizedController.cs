using YZMIS.Components.Security;
using System.Diagnostics.CodeAnalysis;

namespace YZMIS.Tests.Unit.Components.Security
{
    [AllowUnauthorized]
    [ExcludeFromCodeCoverage]
    public class AllowUnauthorizedController : AuthorizedController
    {
    }
}
