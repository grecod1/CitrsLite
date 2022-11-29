using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Tree
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int TreeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TreeType TreeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int VarietyCloneId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public VarietyClone VarietyClone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? ParentTreeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Tree? ParentTree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime ModificationDate { get; set; }
    }
}
