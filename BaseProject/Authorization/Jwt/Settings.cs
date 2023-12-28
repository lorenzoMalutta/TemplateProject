using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Authorization.Jwt
{
    public static class Settings
    {
        private static readonly IConfiguration _configuration;

        static Settings() { }

        public static string Get()
        {
            return _configuration["SymetricSecurityKey"];
        }
    }
}
