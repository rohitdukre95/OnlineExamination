﻿using System;
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
            MCQQuestionsViewModel model = new MCQQuestionsViewModel();
            Candidate candidate=null;
            try
            {              
                candidate = candidateRepository.Get(candId);
                if (candidate != null)
                {
                    model.CandidateId = candidate.Id;
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
                            MCQSubmissionResult obj = new MCQSubmissionResult();
                            obj.CandidateId = candidate.Id;
                            obj.QuestionId = question.Id;
                            obj.SelectedAnswer = question.SelectedAnswer;
                            obj.CorrectAnswer = question.CorrectAnswer;
                            obj.CreatedBy = 1;
                            obj.CreatedOn = DateTime.Now;
                            obj.LastUpdatedBy = 1;
                            obj.LastUpdatedOn = DateTime.Now;
                            mcqSubmissionRepository.Insert(obj);

                        }
                        model.MCQQuestionsList = candidateMCQQuestions;
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
          // return RedirectToAction("RenderQuestion", new { candId = candidate.Id });
            return View(model);
        }

        //public IActionResult RenderQuestion(int candId)
        //{
        //    MCQQuestionsViewModel model = new MCQQuestionsViewModel();
        //    List<MCQSubmissionResult> candidateQuestions = null ;
        //    if (candId!=0)
        //    {
        //        candidateQuestions = context.MCQSubmissionResult.Where(x => x.CandidateId == candId).OrderBy(x => x.QuestionId).ToList();

        //        if(candidateQuestions.Count>0)
        //        {
        //            foreach(var item in candidateQuestions)
        //            {
        //                var questionDetail = context.MCQQuestions.Where(x => x.Id == item.QuestionId).FirstOrDefault();
        //                model.MCQQuestionsList.Add(questionDetail);
        //            }
        //        }
        //        model.CandidateId = candId;
        //    }     
        //    return View("RenderQuestion", model);
        //}
    }
}