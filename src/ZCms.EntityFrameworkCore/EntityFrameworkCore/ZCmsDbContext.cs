using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ZCms.Authorization.Roles;
using ZCms.Authorization.Users;
using ZCms.MultiTenancy;

namespace ZCms.EntityFrameworkCore
{
    public class ZCmsDbContext : AbpZeroDbContext<Tenant, Role, User, ZCmsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ZCmsDbContext(DbContextOptions<ZCmsDbContext> options)
            : base(options)
        {
        }
    }
}
