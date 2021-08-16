using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using Abp.MultiTenancy;
using Abp.Zero.EntityFrameworkCore;

namespace ZeemDots.EntityFrameworkCore
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<ZeemDotsDbContext>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IDbContextResolver dbContextResolver)
            : base(
                unitOfWorkManager,
                connectionStringResolver,
                dbContextResolver)
        {
        }
    }
}
