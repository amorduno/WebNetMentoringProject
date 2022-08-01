using Microsoft.AspNetCore.Identity;

namespace SecurityApp.Models
{
    public class AppUser : IdentityUser
    {
        public string NickName { get; set; }
    }
}
