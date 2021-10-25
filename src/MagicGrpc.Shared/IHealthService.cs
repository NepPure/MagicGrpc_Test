using MagicOnion;
using System;

namespace MagicGrpc.Shared
{
    public interface IHealthService : IService<IHealthService>
    {
        UnaryResult<long> GetServerTime();
    }
}
