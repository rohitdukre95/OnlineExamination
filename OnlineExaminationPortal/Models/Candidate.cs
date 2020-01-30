using OnlineExaminationPortal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.Models
{
    public class Candidate : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        [Display(Name = "Current Company")]
        public string CurrentCompany { get; set; }
       
        [Display(Name = "Experience(In Years)")]
        [Required(ErrorMessage = "Experience is required.")]
        public float ExperienceId { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
