using OnlineExaminationPortal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.Models
{
    public class MCQQuestions : BaseEntity
    {
        [Required]
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        [Required]
        public int CorrectAnswer { get; set; }
        [NotMapped]
        public int SelectedAnswer { get; set; }
        [NotMapped]
        public int MCQSubmissionResultId { get; set; }
    }
}
