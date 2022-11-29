using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    public class Participant
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }

        public string? Description { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; } = "FL";

        public bool IsActive { get; set; }

        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        
        [Required]
        public string ModifiedBy { get; set;}
        
        public DateTime ModificationDate { get; set;}

    }
}