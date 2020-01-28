using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using OnlineExaminationPortal.Common;

namespace OnlineExaminationPortal.Models
{
    public class Experience:BaseEntity
    {     
        [Required]
        public int ExperienceId { get; set; }
        [Required]
        public string ExperienceDescription { get; set; }
    }
}
