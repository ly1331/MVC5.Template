using System;

namespace YZMIS.Components.Mvc
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class NotTrimmedAttribute : Attribute
    {
    }
}
