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
        private readonly IRepository<Experience> expRepository;

        public QuestionController(IRepository<Question> queRepository, IRepository<Experience> expRepository)
        {
            this.queRepository = queRepository;
            this.expRepository = expRepository;
        }
        public IActionResult Index()
        {
            var model = queRepository.GetAll().Where(ques => ques.IsActive == true); 
            var expList = expRepository.GetAll();
            foreach(var item in model)
            {
                var exp = expList.Where(x => x.ExperienceId == item.ExperienceId).FirstOrDefault();
                item.Experience = exp.ExperienceDescription;
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
            var expList = expRepository.GetAll();
            question.ExperienceList = expList.Select(r => new SelectListItem
            {
                Text = r.ExperienceDescription,
                Value = r.ExperienceId.ToString()
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
                    question.ExperienceId = model.ExperienceId;
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
            var expList = expRepository.GetAll();
            model.ExperienceList = expList.Select(r => new SelectListItem
            {
                Text = r.ExperienceDescription,
                Value = r.ExperienceId.ToString()
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
                    ExperienceId = model.ExperienceId,
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
            var expList = expRepository.GetAll();
            question.ExperienceList = expList.Select(r => new SelectListItem
            {
                Text = r.ExperienceDescription,
                Value = r.ExperienceId.ToString()
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