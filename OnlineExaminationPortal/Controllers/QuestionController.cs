using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;

namespace OnlineExaminationPortal.Controllers
{
    [Authorize(Roles = "Admin,HR")]
    public class QuestionController : Controller
    {
        private readonly IRepository<Question> queRepository;
        private readonly IRepository<Position> posRepository;
        private readonly ILogger<QuestionController> logger;

        public QuestionController(IRepository<Question> queRepository, IRepository<Position> posRepository,ILogger<QuestionController> logger)
        {
            this.queRepository = queRepository;
            this.posRepository = posRepository;
            this.logger = logger;
        }
        public IActionResult Index()
        {
            var model = queRepository.GetAll().Where(ques => ques.IsActive == true); 
            var posList = posRepository.GetAll();
            foreach(var item in model)
            {
                var pos = posList.Where(x => x.Id == item.PositionId).FirstOrDefault();
                item.Position = pos.PositionDescription;
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult EditQuestion(int id)
        {
            Question question = null;
            if (id != 0)
            {
                question = queRepository.Get(id);
            }
            else
            {
                question = new Question();
            }
            var posList = posRepository.GetAll();
            question.PositionList = posList.Select(r => new SelectListItem
            {
                Text = r.PositionDescription,
                Value = r.Id.ToString()
            }).ToList();
            return View(question);
        }

        [HttpPost]
        public IActionResult EditQuestion(int id, Question model)
        {
            if (ModelState.IsValid)
            {
                var question = queRepository.Get(id);
                if (question != null)
                {
                    try
                    {
                        question.PositionId = model.PositionId;
                        question.QuestionDescription = model.QuestionDescription.Trim();
                        question.Marks = model.Marks;
                        question.IsActive = true;
                        question.LastUpdatedOn = DateTime.Now;
                        question.LastUpdatedBy = 1;
                        queRepository.Update(question);
                    }
                    catch(Exception ex)
                    {
                        logger.LogError($"Error while updating question: {ex}");
                        ViewBag.ErrorTitle = $"Error updating question";
                        ViewBag.ErrorMessage = $"Error while updating the question : {model.QuestionDescription}";
                        return View("Error");
                    }
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult AddCodingQuestion()
        {
            Question model = new Question();
            var posList = posRepository.GetAll();
            model.PositionList = posList.Select(r => new SelectListItem
            {
                Text = r.PositionDescription,
                Value = r.Id.ToString()
            }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddCodingQuestion(Question model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Question question = new Question
                    {
                        QuestionDescription = model.QuestionDescription.Trim(),
                        PositionId = model.PositionId,
                        Marks = model.Marks,
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        IsActive = true,
                        LastUpdatedBy = 1,
                        LastUpdatedOn = DateTime.Now
                    };
                    queRepository.Insert(question);
                    return RedirectToAction("Index");
                }
                catch(Exception ex)
                {
                    logger.LogError($"Error while adding question: {ex}");
                    ViewBag.ErrorTitle = $"Error adding question";
                    ViewBag.ErrorMessage = $"Error while adding the question : {model.QuestionDescription}";
                    return View("Error");
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult DeleteQuestion(int id)
        {
            Question question = null;
            if (id != 0)
            {
                question = queRepository.Get(id);
            }
            else
            {
                question = new Question();
            }
            var posList = posRepository.GetAll();
            question.PositionList = posList.Select(r => new SelectListItem
            {
                Text = r.PositionDescription,
                Value = r.Id.ToString()
            }).ToList();
            return View(question);
        }

        [HttpPost]
        public IActionResult DeleteQuestion(int id, Question model)
        {

            Question question = queRepository.Get(id);
            if (question != null)
            {
                try
                {
                    question.IsActive = false;
                    queRepository.Update(question);
                }
                catch(Exception ex)
                {
                    logger.LogError($"Error while deleting question: {ex}");
                    ViewBag.ErrorTitle = $"Error deleting question";
                    ViewBag.ErrorMessage = $"Error while deleting the question : {model.QuestionDescription}";
                    return View("Error");
                }               
            }
            return RedirectToAction("Index");
        }
    }
}