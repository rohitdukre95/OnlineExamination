using OnlineExaminationPortal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required(ErrorMessage = "Year required.")]
        public int ExperienceYear { get; set; } 

        [Display(Name = "Experience(In Months)")]
        [Required(ErrorMessage = "Month required.")]
        public int ExperienceMonth { get; set; }
        [Display(Name = "Apply for Position")]
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public int IsExamCleared { get; set; } = 2;
        public int CandidateStatus { get; set; }
        [NotMapped]
        public string StatusString { get; set; }
        [NotMapped]
        public string IsExamClearedString { get; set; }
        public int Marks { get; set; }
    }
}
