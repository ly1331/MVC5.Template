using System;

namespace YZMIS.Services
{
    public interface IService : IDisposable
    {
        Int32 CurrentAccountId { get; set; }
    }
}