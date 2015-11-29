using Microsoft.AspNet.Identity.EntityFramework;

namespace WorkEffect.Website.Data
{
    public class AppUser : IdentityUser
    {
        public override string Id { get; set; }

        public string Name { get; set; }

        public override string Email { get; set; }
    }
}
