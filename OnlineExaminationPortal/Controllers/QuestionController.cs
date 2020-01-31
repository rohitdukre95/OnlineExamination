using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;

namespace OnlineExaminationPortal.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IRepository<Question> queRepository;
        private readonly IRepository<Position> posRepository;

        public QuestionController(IRepository<Question> queRepository, IRepository<Position> posRepository)
        {
            this.queRepository = queRepository;
            this.posRepository = posRepository;
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
                    question.PositionId = model.PositionId;
                    question.QuestionDescription = model.QuestionDescription;
                    question.Marks = model.Marks;
                    question.IsActive = true;
                    question.LastUpdatedOn = DateTime.Now;
                    question.LastUpdatedBy = 1;
                    queRepository.Update(model);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult AddQuestion()
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
        public IActionResult AddQuestion(Question model)
        {
            if (ModelState.IsValid)
            {
                Question question = new Question
                {
                    QuestionDescription = model.QuestionDescription,
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
                question.IsActive = false;
                queRepository.Update(question);
            }

            return RedirectToAction("Index");
        }

    }
}