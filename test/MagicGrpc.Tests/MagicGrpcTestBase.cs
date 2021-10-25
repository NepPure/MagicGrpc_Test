using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MagicGrpc.EntityFrameworkCore;
using MagicGrpc.Tests.TestDatas;

namespace MagicGrpc.Tests
{
    public class MagicGrpcTestBase : AbpIntegratedTestBase<MagicGrpcTestModule>
    {
        public MagicGrpcTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MagicGrpcDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MagicGrpcDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MagicGrpcDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MagicGrpcDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MagicGrpcDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MagicGrpcDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MagicGrpcDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MagicGrpcDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
