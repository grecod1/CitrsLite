using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [Required]
        public string RegistrationNumber { get; set; }

        public int? SupplierId { get; set; }
        public Participant? Supplier { get; set; }

        public int RecieverId { get; set; }
        public Participant Reciever { get; set; }

        public ICollection<Budwood> Budwoods { get; set; }

        public string? Description { get; set; }

        bool IsActive { get; set; }

        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }

        [Required]
        public string ModifiedBy { get; set;}
        public DateTime ModificationDate { get; set;}
    }
}
