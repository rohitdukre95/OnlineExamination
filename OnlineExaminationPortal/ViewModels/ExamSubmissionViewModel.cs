using OnlineExaminationPortal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.ViewModels
{
    public class ExamSubmissionViewModel:BaseEntity
    {
        public int QuestionNumber { get; set; }
        public string QuestionDescription { get; set; }
        public int CandidateId { get; set; }
        public int LanguageId { get; set; }
        public int ExperienceId { get; set; }
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
        public int PositionId { get; set; }

    }
}
