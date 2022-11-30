using CitrsLite.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Entity
{
    public static class SeedData
    {
        public static void Initialize(CitrsLiteContext db)
        {
            var treeTypes = new TreeType[]
            {
                new TreeType()
                {
                    Name = "Parent Tree",
                    Description = "This is the unregulated source tree that provided the base variety clone",
                    CreatedBy = "DOACS\\grecod",
                    CreationDate = DateTime.Now,
                    ModifiedBy = "DOACS\\grecod",
                    ModificationDate = DateTime.Now
                }
            };
        }
    }
}
