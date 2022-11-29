using CitrsLite.Data.Models;
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
        public DbSet<Participant> Participants { get; set; }
        public DbSet<VarietyClone> VarietyClones { get; set; }


        public CitrsLiteContext(DbContextOptions<CitrsLiteContext> options) : base(options) { }

        public CitrsLiteContext(string connectionString)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=TLHSQL17DEV\\DPI;Initial Catalog=CitrsLite;Integrated Security=True";

            optionsBuilder.UseSqlServer(connectionString);
        }
        
    }
}
