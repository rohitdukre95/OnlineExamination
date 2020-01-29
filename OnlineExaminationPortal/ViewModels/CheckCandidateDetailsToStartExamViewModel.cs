using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.ViewModels
{
    public class CheckCandidateDetailsToStartExamViewModel
    {
        [Required]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Mobile { get; set; }
    }
}
