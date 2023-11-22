
using Microsoft.AspNetCore.Identity;

namespace Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName {  get; set; }
        public string AvatarUrl { get; set; }
        public virtual ICollection<UserRoleMap> UserRoleMaps { get; set; }
    }
}
