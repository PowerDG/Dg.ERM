using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Dg.ERM.EntityFrameworkCore;
using Dg.ERM.Tests.TestDatas;

namespace Dg.ERM.Tests
{
    public class ERMTestBase : AbpIntegratedTestBase<ERMTestModule>
    {
        public ERMTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<ERMDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<ERMDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<ERMDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ERMDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<ERMDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<ERMDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<ERMDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ERMDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
