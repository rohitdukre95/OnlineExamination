using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineExaminationPortal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.Models
{
    public class Question : BaseEntity
    {
        [Required(ErrorMessage ="Question Description is required.")]
        public string QuestionDescription { get; set; }
        [Required]
        public float? Marks { get; set; }
       
        [Display(Name = "Experience")]
        [Required(ErrorMessage = "{0} is required.")]
        public int? ExperienceId { get; set; }
        public bool IsEnabled { get; set; }
        [NotMapped]
        public string Experience { get; set; }
        
        [NotMapped]       
        public List<SelectListItem> ExperienceList { get; set; }   
    }
}
