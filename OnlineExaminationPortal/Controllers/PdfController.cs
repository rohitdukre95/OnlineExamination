using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;
using Rotativa.AspNetCore;

namespace OnlineExaminationPortal.Controllers
{
    [Authorize(Roles = "Admin,HR")]
    public class PdfController : Controller
    {
        private readonly IRepository<ExamSubmissionResult> examRepository;
        private readonly IRepository<Candidate> canRepository;
        private readonly IRepository<Position> posRepository;
        private readonly ILogger<PdfController> logger;

        public PdfController(IRepository<ExamSubmissionResult> examRepository, IRepository<Candidate> canRepository,IRepository<Position> posRepository,ILogger<PdfController> logger)
        {
            this.examRepository = examRepository;
            this.canRepository = canRepository;
            this.posRepository = posRepository;
            this.logger = logger;
        }
        public IActionResult Index(int canId)
        {
            PdfData pdfData = new PdfData();
            if (canId != 0)
            {
                pdfData.ExamSubmissionResults = examRepository.GetAll().Where(can => can.CandidateId == canId).ToList();
                pdfData.Candidate = canRepository.Get(canId);
                pdfData.Candidate.Position = posRepository.Get(pdfData.Candidate.PositionId);
                pdfData.DocumentTitle = "Exam Result";
            }
            return View(pdfData);
        }
        public ActionResult ConvertToPDF(int canId)
        {
            try
            {
                PdfData pdfData = new PdfData();
                pdfData.ExamSubmissionResults = examRepository.GetAll().Where(can => can.CandidateId == canId).ToList();
                pdfData.Candidate = canRepository.Get(canId);
                pdfData.Candidate.Position = posRepository.Get(pdfData.Candidate.PositionId);
                pdfData.DocumentTitle = "Exam Result";

                return new ViewAsPdf("Index", pdfData)
                {
                    FileName = pdfData.Candidate.Id + "." + pdfData.Candidate.Name + ".pdf",
                    PageSize = Rotativa.AspNetCore.Options.Size.A4,
                    PageOrientation = Rotativa.AspNetCore.Options.Orientation.Portrait,
                    PageMargins = { Left = 20, Bottom = 20, Right = 20, Top = 20 }
                };
            }
            catch(Exception ex)
            {
                logger.LogError($"Error while generating the pdf : {ex}");
            }

            ViewBag.ErrorTitle = $"Error Occurred";
            ViewBag.ErrorMessage = $"Error while generating PDF";
            return View("Error");
        }
    }
}