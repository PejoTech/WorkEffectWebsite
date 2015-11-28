using Microsoft.AspNet.Identity.EntityFramework;

namespace WorkEffect.Website.Data
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }

        public override string Email { get; set; }
    }
}
