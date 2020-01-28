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
        public string Email { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        public string CurrentCompany { get; set; }
        [Required]      
        public float ExperienceId { get; set; }
    }
}
