using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    /// <summary>
    /// This class covers the Variety Clone object.
    /// </summary>
    public class VarietyClone
    {
        /// <summary>
        /// This is the Id of the Variety Clone.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// This is the Name of the Variety Clone and is Required.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// This is a Collection of Trees under the Variety Clone object.
        /// </summary>
        public ICollection<Tree> Trees { get; set; }

        /// <summary>
        /// This is an optional Description of the Variety Clone.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// This boolean determines the Status of the Variety Clone.
        /// True = Active, False = Inactive.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// This is the User who Created the Variety Clone.
        /// </summary>
        [Required]
        public string CreatedBy { get; set; }

        /// <summary>
        /// This is the Date on which the User Created the Variety Clone.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// This is the User who Modified the Variety Clone.
        /// </summary>
        [Required]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// This is the Date on which the User Modified the Variety Clone.
        /// </summary>
        public DateTime ModificationDate { get; set; }
    }
}
