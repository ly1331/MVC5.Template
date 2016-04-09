using YZMIS.Components.Alerts;
using System;
using System.Web.Mvc;

namespace YZMIS.Validators
{
    public interface IValidator : IDisposable
    {
        ModelStateDictionary ModelState { get; set; }
        Int32 CurrentAccountId { get; set; }
        AlertsContainer Alerts { get; set; }
    }
}
