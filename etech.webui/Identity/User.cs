using Microsoft.AspNetCore.Identity;

namespace etech.webui.Identity
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}