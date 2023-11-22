using Microsoft.AspNetCore.Identity;

namespace Entities
{
    public class Role : IdentityRole
    {
        public virtual ICollection<UserRoleMap> UserRoleMaps { get; set; }
    }
}
