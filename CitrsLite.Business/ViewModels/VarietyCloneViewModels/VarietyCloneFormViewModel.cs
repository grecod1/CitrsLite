using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Business.ViewModels.VarietyCloneViewModels
{
    public class VarietyCloneFormViewModel
    {
        /// <summary>
        /// This is the Id of the Variety Clone.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// This is the Name of the Variety Clone and is Required.
        /// </summary>
        [Required]
        [Display(Name= "Variety Name")]
        public string Name { get; set; }       

        /// <summary>
        /// This is an optional Description of the Variety Clone.
        /// </summary>
        public string? Description { get; set; }

        [Display(Name = "Status")]
        /// <summary>
        /// This boolean determines the Status of the Variety Clone.
        /// True = Active, False = Inactive.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
