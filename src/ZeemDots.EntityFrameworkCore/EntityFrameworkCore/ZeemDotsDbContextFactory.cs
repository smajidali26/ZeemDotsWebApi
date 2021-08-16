using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ZeemDots.Configuration;
using ZeemDots.Web;

namespace ZeemDots.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ZeemDotsDbContextFactory : IDesignTimeDbContextFactory<ZeemDotsDbContext>
    {
        public ZeemDotsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ZeemDotsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ZeemDotsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ZeemDotsConsts.ConnectionStringName));

            return new ZeemDotsDbContext(builder.Options);
        }
    }
}
