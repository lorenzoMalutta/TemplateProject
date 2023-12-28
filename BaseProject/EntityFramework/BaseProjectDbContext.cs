using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.EntityFramework
{
    public class BaseProjectDbContext : DbContext
    {
        public BaseProjectDbContext(DbContextOptions<BaseProjectDbContext> options) : base(options) { }

        protected BaseProjectDbContext(DbContextOptions options) : base(options) { }
    }
}
