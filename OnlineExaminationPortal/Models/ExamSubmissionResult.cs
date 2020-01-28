using OnlineExaminationPortal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.Models
{
    public class ExamSubmissionResult : BaseEntity
    {
        [Required]
        public int CandidateId { get; set; }
        [Required]
        public int QuestionNumber { get; set;}
        public string Code { get; set; }
        public string Output { get; set; }
    }
}
