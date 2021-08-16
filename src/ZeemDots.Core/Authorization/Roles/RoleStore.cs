using Abp.Authorization.Roles;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using ZeemDots.Authorization.Users;

namespace ZeemDots.Authorization.Roles
{
    public class RoleStore : AbpRoleStore<Role, User>
    {
        public RoleStore(
            IUnitOfWorkManager unitOfWorkManager,
            IRepository<Role> roleRepository,
            IRepository<RolePermissionSetting, long> rolePermissionSettingRepository)
            : base(
                unitOfWorkManager,
                roleRepository,
                rolePermissionSettingRepository)
        {
        }
    }
}
