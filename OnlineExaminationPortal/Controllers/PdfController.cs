using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;
using Rotativa.AspNetCore;

namespace OnlineExaminationPortal.Controllers
{
    [AllowAnonymous]
    public class PdfController : Controller
    {
        private readonly IRepository<ExamSubmissionResult> examRepository;
        private readonly IRepository<Candidate> canRepository;
        private readonly IRepository<Position> posRepository;

        public PdfController(IRepository<ExamSubmissionResult> examRepository, IRepository<Candidate> canRepository,IRepository<Position> posRepository)
        {
            this.examRepository = examRepository;
            this.canRepository = canRepository;
            this.posRepository = posRepository;
        }
        public IActionResult Index()
        {
            //PdfData pdfData = new PdfData();
            //pdfData.ExamSubmissionResults = examRepository.GetAll().Where(can => can.CandidateId == 1).ToList();
            //pdfData.Candidate = canRepository.Get(1);
            //pdfData.Candidate.Position = posRepository.Get(pdfData.Candidate.PositionId);
            //pdfData.DocumentTitle = "Exam Result";

            return View();

        }
        public ActionResult ConvertToPDF()
        {
            PdfData pdfData = new PdfData();
            pdfData.ExamSubmissionResults = examRepository.GetAll().Where(can => can.CandidateId == 1).ToList();
            pdfData.Candidate = canRepository.Get(1);
            pdfData.Candidate.Position = posRepository.Get(pdfData.Candidate.PositionId);
            pdfData.DocumentTitle = "Exam Result";

            return new ViewAsPdf("Index",pdfData) { 
                FileName = "PDF Doc.pdf",
                PageSize= Rotativa.AspNetCore.Options.Size.A4,
                PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                PageMargins = { Left = 20, Bottom = 20, Right = 20, Top = 20 }
            };
        }
    }
}