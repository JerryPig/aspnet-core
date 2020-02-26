using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ZCms.Configuration;
using ZCms.Web;

namespace ZCms.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ZCmsDbContextFactory : IDesignTimeDbContextFactory<ZCmsDbContext>
    {
        public ZCmsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ZCmsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ZCmsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ZCmsConsts.ConnectionStringName));

            return new ZCmsDbContext(builder.Options);
        }
    }
}
