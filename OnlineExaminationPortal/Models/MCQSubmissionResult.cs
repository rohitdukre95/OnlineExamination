using OnlineExaminationPortal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.Models
{
    public class MCQSubmissionResult : BaseEntity
    {
        public int CandidateId { get; set; }
        public int QuestionId { get; set; }
        public int CorrectAnswer { get; set; }
        public int SelectedAnswer { get; set; }
    }
}
