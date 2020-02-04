using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.Models
{
    public class PdfData
    {
        public String DocumentTitle { get; set; }
        public List<ExamSubmissionResult> ExamSubmissionResults{ get; set; }
        public Candidate Candidate { get; set; }
    }
}
