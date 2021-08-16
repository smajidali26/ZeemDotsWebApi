using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ZeemDots.EntityFrameworkCore
{
    public static class ZeemDotsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ZeemDotsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ZeemDotsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
