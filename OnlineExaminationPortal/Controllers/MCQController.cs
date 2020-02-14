using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;

namespace OnlineExaminationPortal.Controllers
{
    public class MCQController : Controller
    {
        private readonly IRepository<MCQQuestions> mcqRepository;
        private readonly IRepository<Question> quesRepository;
        private readonly ILogger<MCQController> logger;

        public MCQController(IRepository<MCQQuestions> mcqRepository, IRepository<Question> quesRepository, ILogger<MCQController> logger)
        {
            this.mcqRepository = mcqRepository;
            this.quesRepository = quesRepository;
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var mcqQuestionsList = mcqRepository.GetAll();
            return View(mcqQuestionsList);
        }

        [HttpGet]
        public IActionResult AddMCQQuestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMCQQuestion(MCQQuestions model)
        {
            if (ModelState.IsValid)
            {
                mcqRepository.Insert(model);
            }
            return RedirectToAction("Index");
        }
      
        [HttpGet]
        public IActionResult EditMCQQuestion(int id)
        {
            MCQQuestions mcqQuestion = null;
            if (id != 0)
            {
                mcqQuestion = mcqRepository.Get(id);
            }
            else
            {
                mcqQuestion = new MCQQuestions();
            }          
            return View(mcqQuestion);
        }

        [HttpPost]
        public IActionResult EditMCQQuestion(int id, MCQQuestions model)
        {
            if (ModelState.IsValid)
            {
                var question = mcqRepository.Get(id);
                if (question != null)
                {
                    try
                    {
                        question.Question = model.Question;
                        question.Option1 = model.Option1;
                        question.Option2 = model.Option2;
                        question.Option3 = model.Option3;
                        question.Option4 = model.Option4;
                        question.CorrectAnswer = model.CorrectAnswer;
                        question.LastUpdatedOn = DateTime.Now;
                        question.LastUpdatedBy = 1;
                        mcqRepository.Update(question);
                    }
                    catch (Exception ex)
                    {
                        logger.LogError($"Error while updating question: {ex}");
                        ViewBag.ErrorTitle = $"Error updating question";
                        ViewBag.ErrorMessage = $"Error while updating the question : {model.Question}";
                        return View("Error");
                    }
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteMCQQuestion(int id)
        {
            MCQQuestions question = null;
            if (id != 0)
            {
                question = mcqRepository.Get(id);
            }
            else
            {
                question = new MCQQuestions();
            }         
            return View(question);
        }

        [HttpPost]
        public IActionResult DeleteMCQQuestion(int id, MCQQuestions model)
        {

            MCQQuestions question = mcqRepository.Get(id);
            if (question != null)
            {
                try
                {
                    question.IsActive = false;
                    mcqRepository.Update(question);
                }
                catch (Exception ex)
                {
                    logger.LogError($"Error while deleting question: {ex}");
                    ViewBag.ErrorTitle = $"Error deleting question";
                    ViewBag.ErrorMessage = $"Error while deleting the question : {model.Question}";
                    return View("Error");
                }
            }
            return RedirectToAction("Index");
        }

    }
}