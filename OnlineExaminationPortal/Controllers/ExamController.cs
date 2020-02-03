using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;
using OnlineExaminationPortal.ViewModels;

namespace OnlineExaminationPortal.Controllers
{
    [AllowAnonymous]
    public class ExamController : Controller
    {
        private readonly IRepository<Question> queRepository;
        private readonly IRepository<Candidate> candidateRepository;
        private readonly IRepository<ExamSubmissionResult> submissionRepository;
        private readonly AppDbContext context;

        public ExamController(IRepository<Question> queRepository ,
            IRepository<Candidate> candidateRepository,
            IRepository<ExamSubmissionResult> submissionRepository,
            AppDbContext context)
        {
            this.queRepository = queRepository;
            this.candidateRepository = candidateRepository;
            this.submissionRepository = submissionRepository;
            this.context = context;
        }
        public IActionResult Index(int positionId,int candidateId)
        {
            ViewBag.PositionId = positionId;
            ViewBag.CandidateId = candidateId;
            return View();
        }

        [HttpGet]
        public IActionResult StartExam(int pageNumber,int positionId, int candidateId)
        {
            try
            {
                var candidate = candidateRepository.Get(candidateId);
                if (candidate != null)
                {
                    var examSubmissionResults = context.ExamSubmissionResults.Where(x => x.CandidateId == candidateId).ToList();
                    if (examSubmissionResults == null || examSubmissionResults.Count == 0)
                    {
                        var candidateQuestions = queRepository.GetAll().Where(x => x.PositionId == positionId).OrderBy(q => q.Id).Take(4);
                        foreach (var question in candidateQuestions)
                        {
                            ExamSubmissionResult obj = new ExamSubmissionResult
                            {
                                CandidateId = candidate.Id,
                                PositionId = question.PositionId,
                                QuestionNumber = question.Id,
                                QuestionDescription = question.QuestionDescription,
                                CreatedOn = DateTime.Now,
                                CreatedBy = 1,
                                LastUpdatedBy = 1,
                                LastUpdatedOn = DateTime.Now,
                                LanguageId = 1
                            };
                            submissionRepository.Insert(obj);
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return RedirectToAction("RenderQuestion",new { pageNumber = pageNumber, positionId = positionId, candidateId=candidateId } );
        }

      
        public IActionResult RenderQuestion(int pageNumber, int positionId, int candidateId)
        {
            ExamQuestionsViewModel model = new ExamQuestionsViewModel();
            var allQuestions = queRepository.GetAll().Where(x => x.PositionId == positionId).OrderBy(q => q.Id);
            var question = allQuestions.Skip(pageNumber - 1).Take(1).FirstOrDefault();
            model.QuestionDescription = question.QuestionDescription;
            model.QuestionNumber = question.Id;
            model.PositionId = positionId;
            model.PageNumber = pageNumber;
            model.CandidateId = candidateId;
            model.SubmissonResult =context.ExamSubmissionResults.Where(x => x.CandidateId == model.CandidateId && x.QuestionNumber == model.QuestionNumber).FirstOrDefault();
            return View("RenderQuestion",model);
        }


        [HttpPost]
        public IActionResult SaveDataOnNextAndBack([FromBody] ExamSubmissionViewModel model)
        {
            if (model != null)
            {              
                var candidateCurQuestion = context.ExamSubmissionResults.Where(x => x.CandidateId == model.CandidateId && x.QuestionNumber == model.QuestionNumber).FirstOrDefault();
                if (candidateCurQuestion != null)
                {                   
                    candidateCurQuestion.SandboxMessage = model.SandboxMessage;
                    candidateCurQuestion.SourceCode = model.SourceCode;
                    candidateCurQuestion.StandardError = model.StandardError;
                    candidateCurQuestion.StandardInput = model.StandardInput;
                    candidateCurQuestion.StandardOutput = model.StandardOutput;
                    candidateCurQuestion.StatusLine = model.StatusLine;
                    candidateCurQuestion.CommandLineArguments = model.CommandLineArguments;
                    candidateCurQuestion.CompilerOptions = model.CompilerOptions;
                    candidateCurQuestion.CompileTimeOutput = model.CompileTimeOutput;
                    candidateCurQuestion.LanguageId = 1;
                    candidateCurQuestion.LastUpdatedBy = 1;
                    candidateCurQuestion.LastUpdatedOn = DateTime.Now;
                    submissionRepository.Update(candidateCurQuestion);
                }
            }

            //return RedirectToAction("RenderQuestion", "Exam", new { pageNumber = model.PageNumber, positionId = model.PositionId, candidateId = model.CandidateId });
            return Json(model);
        }

        [HttpGet]
        public IActionResult GetQuestionsAlreadySavedData(ExamQuestionsViewModel model)
        {
            var submission = submissionRepository.GetAll().Where(x => x.CandidateId == model.CandidateId && x.QuestionNumber == model.QuestionNumber).FirstOrDefault();
            if (submission != null)
            {
                return Json(submission);
            }

            return View("RenderQuestion", model);
        }
        public IActionResult TestSubmit()
        {
            return View();
        }
    }
}