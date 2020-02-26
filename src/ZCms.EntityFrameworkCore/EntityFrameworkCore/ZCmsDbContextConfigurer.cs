using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ZCms.EntityFrameworkCore
{
    public static class ZCmsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ZCmsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ZCmsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
