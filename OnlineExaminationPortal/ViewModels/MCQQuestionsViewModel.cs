using OnlineExaminationPortal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.ViewModels
{
    public class MCQQuestionsViewModel
    {
        public int CandidateId { get; set; }
        public List<MCQQuestions> MCQQuestionsList { get; set; }
    }
}
