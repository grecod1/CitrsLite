using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    public class Tree
    {
        public int Id { get; set; }

        [Required]
        public string Number { get; set; }

        public int TreeTypeId { get; set; }
        public TreeType TreeType { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }

        [Required]
        public string ModifiedBy { get; set; }
        public DateTime ModificationDate { get; set; }

    }
}
