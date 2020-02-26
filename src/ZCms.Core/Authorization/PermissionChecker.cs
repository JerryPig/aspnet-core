using Abp.Authorization;
using ZCms.Authorization.Roles;
using ZCms.Authorization.Users;

namespace ZCms.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
