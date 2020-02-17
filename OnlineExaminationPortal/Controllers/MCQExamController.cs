using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;
using OnlineExaminationPortal.ViewModels;

namespace OnlineExaminationPortal.Controllers
{
    public class MCQExamController : Controller
    {
        private readonly IRepository<Candidate> candidateRepository;
        private readonly AppDbContext context;
        private readonly ILogger<ExamController> logger;
        private readonly IRepository<MCQQuestions> mcqQueRepository;
        private readonly IRepository<MCQSubmissionResult> mcqSubmissionRepository;

        public MCQExamController(IRepository<Candidate> candidateRepository, AppDbContext context,
            ILogger<ExamController> logger, IRepository<MCQQuestions> mcqQueRepository, IRepository<MCQSubmissionResult> mcqSubmissionRepository)
        {
            this.candidateRepository = candidateRepository;
            this.context = context;
            this.logger = logger;
            this.mcqQueRepository = mcqQueRepository;
            this.mcqSubmissionRepository = mcqSubmissionRepository;
        }
        public IActionResult Index(int candId)
        {
            ViewBag.CandidateId = candId;
            return View();
        }
        [HttpGet]
        public IActionResult StartMCQExam(int candId)
        {
            try
            {
                var candidate = candidateRepository.Get(candId);
                if (candidate != null)
                {
                    //if (candidate.CandidateStatus != 4 && candidate.IsConsumed == 0)
                    //{
                    //    candidate.CandidateStatus = 3;
                    //    candidateRepository.Update(candidate);
                    var mcqExamSubmissionResults = context.MCQSubmissionResult.Where(x => x.CandidateId == candId).ToList();
                    if (mcqExamSubmissionResults == null || mcqExamSubmissionResults.Count == 0)
                    {
                        var candidateMCQQuestions = mcqQueRepository.GetAll().OrderBy(q => q.Id).ToList();
                        //if (candidateMCQQuestions.Count >= 4)
                        //{
                        //    candidateQuestions = candidateQuestions.Take(4).ToList();
                        //}
                        foreach (var question in candidateMCQQuestions)
                        {
                            MCQQuestionsViewModel obj = new MCQQuestionsViewModel
                            {
                                CandidateId = candidate.Id,
                                MCQQuestionsList = candidateMCQQuestions                              
                            };
                            foreach(var mcq in obj.MCQQuestionsList)
                            {
                                MCQSubmissionResult model = new MCQSubmissionResult();
                                model.CandidateId = obj.CandidateId;
                                model.QuestionId = mcq.Id;
                                model.SelectedAnswer = mcq.SelectedAnswer;
                                model.CorrectAnswer = mcq.CorrectAnswer;
                                model.CreatedBy = 1;
                                model.CreatedOn = DateTime.Now;
                                model.LastUpdatedBy = 1;
                                model.LastUpdatedOn = DateTime.Now;
                                mcqSubmissionRepository.Insert(model);
                            }
                            
                        }
                    }
                }
                //else
                //{
                //    ViewBag.ErrorMessage = "Exam Link is Expired or Already Submitted the exam";
                //    return View("ExamLinkExpired");
                //}

            }
            catch (Exception ex)
            {
                logger.LogError($"Error while starting exam: {ex}");
                ViewBag.ErrorTitle = $"Error";
                ViewBag.ErrorMessage = $"Error while adding starting the exam";
                return View("Error");
            }
            //return RedirectToAction("RenderQuestion", new { pageNumber = pageNumber, positionId = positionId, candidateId = candidateId });
            return View();
        }

    }
}