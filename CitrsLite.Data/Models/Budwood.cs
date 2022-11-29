using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    public class Budwood
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public string Name { get; set; }

        public int RegistrationId { get; set; }
        public Registration Registration { get; set; }

        public int TreeId { get; set; }
        public Tree Tree { get; set; }

        public int? NumberBudded { get; set; }
        public int? NumberGrafted { get; set; }

        public bool IsActive { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        public string ModifiedBy { get; set; }
        public DateTime ModificationDate { get; set; }
    }
}
