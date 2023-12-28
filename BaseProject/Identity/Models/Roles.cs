using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Identity.Models
{
    public class Roles : IdentityRole
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }
}
