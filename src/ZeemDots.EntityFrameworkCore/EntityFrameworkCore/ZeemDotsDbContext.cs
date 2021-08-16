using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ZeemDots.Authorization.Roles;
using ZeemDots.Authorization.Users;
using ZeemDots.MultiTenancy;

namespace ZeemDots.EntityFrameworkCore
{
    public class ZeemDotsDbContext : AbpZeroDbContext<Tenant, Role, User, ZeemDotsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ZeemDotsDbContext(DbContextOptions<ZeemDotsDbContext> options)
            : base(options)
        {
        }
    }
}
