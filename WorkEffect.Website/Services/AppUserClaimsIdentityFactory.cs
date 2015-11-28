using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using WorkEffect.Website.Data;

namespace WorkEffect.Website.Services
{
    public class AppUserClaimsIdentityFactory : ClaimsIdentityFactory<AppUser>
    {
        public async Task<ClaimsIdentity> CreateAsync(
            UserManager<AppUser> manager,
            AppUser user,
            string authenticationType)
        {
            var identity = await base.CreateAsync(manager, user, authenticationType);

            return identity;
        }
    }
}
