using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Authorization.Claims
{
    public static class ClaimExtension
    {
        public static async Task AddClaim(this ClaimsPrincipal claimsPrincipal, string claimType, string claimValue)
        {
            var identity = (ClaimsIdentity)claimsPrincipal.Identity;
            identity.AddClaim(new Claim(claimType, claimValue));
            await Task.CompletedTask;
        }
    }
}
