using Microsoft.AspNetCore.Identity;

namespace InnoviaReach___TFI___FrontEnd.Data
{
    public class UsersPrivileges : IdentityUserRole<string>
    {
        public int Id { get; set; }
        public virtual ICollection<Users> PrivilegesUsers { get; set; }
    }
}
