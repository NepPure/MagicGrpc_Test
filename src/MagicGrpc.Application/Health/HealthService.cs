using MagicGrpc.Shared;
using MagicOnion.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Dependency;
using MagicOnion;
using System.Threading;
using Grpc.Core;

namespace MagicGrpc.Health
{
    public class HealthService : ServiceBase<IHealthService>, IHealthService, ITransientDependency
    {
#pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        public async UnaryResult<long> GetServerTime()
#pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        {
            return DateTimeOffset.Now.ToUnixTimeMilliseconds();
        }
    }
}
