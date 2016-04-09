using YZMIS.Objects;
using System;

namespace YZMIS.Validators
{
    public interface IRoleValidator : IValidator
    {
        Boolean CanCreate(RoleView view);
        Boolean CanEdit(RoleView view);
    }
}
