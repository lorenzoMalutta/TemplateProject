using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }
    }
}
