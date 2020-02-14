using OnlineExaminationPortal.Common;
using OnlineExaminationPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string QuestionDescription { get; set; }      
       
        public int PageNumber { get; set; }
        public string SourceCode { get; set; }
        public string CompilerOptions { get; set; }
        public string CommandLineArguments { get; set; }
        public string StandardInput { get; set; }
        public string StandardOutput { get; set; }
        public string StandardError { get; set; }
        public string CompileTimeOutput { get; set; }
        public string SandboxMessage { get; set; }
        public string StatusLine { get; set; }  
        [ForeignKey("PositionRef")]
        public int PositionId { get; set; }
        public Position PositionRef { get; set; }
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public static implicit operator ExamSubmissionResult(ExamSubmissionViewModel v)
        {
            throw new NotImplementedException();
        }
       
    }
}
