using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    /// <summary>
    /// This class covers the Tree Type object.
    /// </summary>
    public class TreeType
    {
        /// <summary>
        /// This is the Id of the Tree Type.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// This is the Name of the Tree Type and is Required.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// This is a Collection of Trees under the Tree Type object.
        /// </summary>
        public ICollection<Tree> Trees { get; set; }

        /// <summary>
        /// This is an optional Description of the Tree Type.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// This is the User who Created the Tree Type.
        /// </summary>
        [Required]
        public string CreatedBy { get; set; }

        /// <summary>
        /// This is the Date on which the User Created the Tree Type.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// This is the User who Modified the Tree Type.
        /// </summary>
        [Required]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// This is the Date on which the User Modified the Tree Type.
        /// </summary>
        public DateTime ModificationDate { get; set; }
    }
}
