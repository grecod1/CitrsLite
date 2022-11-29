using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    /// <summary>
    /// The data model for Budwood or Budwood cuts on registration orders
    /// </summary>
    public class Budwood
    {
        /// <summary>
        /// Id number for Budwood cut
        /// </summary>
        [Required]
        public int Id { get; set; }
        /// <summary>
        /// The amount of budeyes from a cut
        /// </summary>
        [Required]
        public int Quantity { get; set; }
        /// <summary>
        /// The name of the Budwood
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// The Id number of the associated Registration object
        /// </summary>
        public int RegistrationId { get; set; }
        /// <summary>
        /// The Registration object that is linked to the Budwood
        /// </summary>
        public Registration Registration { get; set; }
        /// <summary>
        /// The Id number of the associated Tree object
        /// </summary>
        public int TreeId { get; set; }
        /// <summary>
        /// The Tree object associated to the Budwood
        /// </summary>
        public Tree Tree { get; set; }
        /// <summary>
        /// The number of buds taken from the budstick
        /// </summary>
        public int? NumberBudded { get; set; }
        /// <summary>
        /// The number of buds grafted to rootstock
        /// </summary>
        public int? NumberGrafted { get; set; }
        /// <summary>
        /// The boolean value for whether Budwood is active
        /// </summary>
        public bool IsActive { get; set; }
        /// <summary>
        /// The user that created the Budwood object
        /// </summary>
        [Required]
        public string CreatedBy { get; set; }
        /// <summary>
        /// The date of when Budwood was initialized
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// The user that last updated the Budwood object
        /// </summary>
        [Required]
        public string ModifiedBy { get; set; }
        /// <summary>
        /// The date of when Budwood was last updated
        /// </summary>
        public DateTime ModificationDate { get; set; }
    }
}
