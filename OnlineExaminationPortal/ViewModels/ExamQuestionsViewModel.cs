using OnlineExaminationPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.ViewModels
{
    public class ExamQuestionsViewModel
    {
       public string QuestionDescription { get; set; }
       public int QuestionNumber { get; set; }
       public int ExperienceId { get; set; }
       public int PageNumber { get; set; }
       public int CandidateId { get; set; }
    }
}
