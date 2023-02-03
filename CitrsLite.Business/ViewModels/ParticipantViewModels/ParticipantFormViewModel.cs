using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Business.ViewModels.ParticipantViewModels
{
    /// <summary>
    /// The model for the Participant Form View
    /// </summary>
    public class ParticipantFormViewModel
    {
        /// <summary>
        /// The Id number of the Participant
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the Participant
        /// </summary>
        [Required]
        public string? Name { get; set; }
        /// <summary>
        /// The type of Participant (Government/Research/Nursery, etc.)
        /// </summary>
        [Required]
        public string? Type { get; set; }
        /// <summary>
        /// A brief summary or collection of comments about the Participant
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// The phone number for the Participant
        /// </summary>
        [Required]
        [Phone(ErrorMessage = "Please type in a valid phone number")]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
        /// <summary>
        /// The address of the Participant
        /// </summary>
        [Required]
        public string? Address { get; set; }
        /// <summary>
        /// The city of where the Participant is located
        /// </summary>
        [Required]
        [RegularExpression(@"^[A-Z|a-z|\s|-|.|,|']*$", ErrorMessage = "Invalid characters")]
        [MaxLength(150, ErrorMessage = "Too many characters")]
        public string? City { get; set; }
        /// <summary>
        /// The state of where the Participant is located
        /// </summary>
        [Required]
        public string State { get; set; } = "FL";
        /// <summary>
        /// Boolean value of whether the Participant is active
        /// </summary>
        [Display(Name = "Status")]
        public bool IsActive { get; set; } = true;
        /// <summary>
        /// Stores the value of username currently on the view
        /// </summary>
        public string? UserName { get; set; }
    }
}
