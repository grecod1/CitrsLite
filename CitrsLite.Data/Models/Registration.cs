using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    /// <summary>
    /// The data model for the Registration object or the CBR orders that track budwood between participants 
    /// </summary>
    public class Registration
    {
        /// <summary>
        /// The Id number for the Registration within CITRSLite
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The identification used for Registration on forms
        /// </summary>
        [Required]
        public string RegistrationNumber { get; set; }
        /// <summary>
        /// The Id number of the Participant that provided budwood
        /// </summary>
        public int? SupplierId { get; set; }
        /// <summary>
        /// The Participant that provided budwood
        /// </summary>
        public Participant? Supplier { get; set; }
        /// <summary>
        /// The Id number of the Participant that received budwood
        /// </summary>
        public int RecieverId { get; set; }
        /// <summary>
        /// The Participant that received budwood
        /// </summary>
        public Participant Reciever { get; set; }
        /// <summary>
        /// The list of budwood found in the Registration order
        /// </summary>
        public ICollection<Budwood> Budwoods { get; set; }
        /// <summary>
        /// Brief paragraph or few comments regarding the Registration
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Boolean value of whether Registration is active
        /// </summary>
        bool IsActive { get; set; }
        /// <summary>
        /// The user that created the Registration
        /// </summary>
        [Required]
        public string CreatedBy { get; set; }
        /// <summary>
        /// The date the Registration was created
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// The user that last updated the Registration
        /// </summary>
        [Required]
        public string ModifiedBy { get; set;}
        /// <summary>
        /// The date the Registration was last updated
        /// </summary>
        public DateTime ModificationDate { get; set;}
    }
}
