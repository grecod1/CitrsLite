using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    public class Budwood
    {
        public int Quantity { get; set; }
        public string Name { get; set; }

        public int NumberBudded { get; set; }
        public int NumberGrafted { get; set; }

        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
