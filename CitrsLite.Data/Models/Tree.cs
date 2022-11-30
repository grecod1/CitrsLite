using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    /// <summary>
    /// This class covers the Tree object.
    /// </summary>
    public class Tree
    {
        /// <summary>
        /// This is the Id of the Tree.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// This is the Name/Number of the Tree and is Required.
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// This is the Reference to the Tree Type Id.
        /// </summary>
        public int TreeTypeId { get; set; }

        /// <summary>
        /// This is the Reference to the Tree Type.
        /// </summary>
        public TreeType TreeType { get; set; }

        /// <summary>
        /// This is the Reference to the Variety Clone Id.
        /// </summary>
        public int VarietyCloneId { get; set; }

        /// <summary>
        /// This is the Reference to the Variety Clone.
        /// </summary>
        public VarietyClone VarietyClone { get; set; }

        /// <summary>
        /// This is the Reference to the Parent Tree Id.
        /// </summary>
        public int? ParentTreeId { get; set; }

        /// <summary>
        /// This is the Reference to the Parent Tree.
        /// </summary>
        public Tree? ParentTree { get; set; }

        /// <summary>
        /// This is an optional Description of the Tree.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// This boolean determines the Status of the Tree.
        /// True = Active, False = Inactive.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// This is the User who Created the Tree.
        /// </summary>
        [Required]
        public string CreatedBy { get; set; }

        /// <summary>
        /// This is the Date on which the User Created the Tree.
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// This is the User who Modified the Tree.
        /// </summary>
        [Required]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// This is the Date on which the User Modified the Tree.
        /// </summary>
        public DateTime ModificationDate { get; set; }
    }
}
