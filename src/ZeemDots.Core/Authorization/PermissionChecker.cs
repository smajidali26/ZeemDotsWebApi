using Abp.Authorization;
using ZeemDots.Authorization.Roles;
using ZeemDots.Authorization.Users;

namespace ZeemDots.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
