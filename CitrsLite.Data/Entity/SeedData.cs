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
                },
                new TreeType()
                {
                    Name = "Foundation Tree",
                    Description = "This type of source tree is used to provide budwood to participants",
                    CreatedBy = "DOACS\\grecod",
                    CreationDate = DateTime.Now,
                    ModifiedBy = "DOACS\\grecod",
                    ModificationDate = DateTime.Now
                },
                new TreeType()
                {
                    Name = "Scion Tree",
                    Description = "This type of source tree is owned by participants",
                    CreatedBy = "DOACS\\grecod",
                    CreationDate = DateTime.Now,
                    ModifiedBy = "DOACS\\grecod",
                    ModificationDate = DateTime.Now
                },
                new TreeType()
                {
                    Name = "Increase Tree",
                    Description = "This type of source tree cannot generate any future source trees, only field trees",
                    CreatedBy = "DOACS\\grecod",
                    CreationDate = DateTime.Now,
                    ModifiedBy = "DOACS\\grecod",
                    ModificationDate = DateTime.Now
                },
                new TreeType()
                {
                    Name = "STG Tree",
                    Description = "This tree was grown in a lab",
                    CreatedBy = "DOACS\\grecod",
                    CreationDate = DateTime.Now,
                    ModifiedBy = "DOACS\\grecod",
                    ModificationDate = DateTime.Now
                }
            };

            db.TreeTypes.AddRange(treeTypes);
            db.SaveChanges();
        }
    }
}
