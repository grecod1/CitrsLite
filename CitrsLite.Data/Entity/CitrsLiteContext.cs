using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Entity
{
    public class CitrsLiteContext : DbContext
    {


        public CitrsLiteContext(DbContextOptions<CitrsLiteContext> options) : base(options) { }

        public CitrsLiteContext(string connectionString)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "";

            optionsBuilder.UseSqlServer(connectionString);
        }
        
    }
}
