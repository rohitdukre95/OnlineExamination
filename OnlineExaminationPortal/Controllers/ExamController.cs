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

        public ExamController(IRepository<Question> queRepository )
        {
            this.queRepository = queRepository;
        }
        public IActionResult Index(int experienceId)
        {
            ViewBag.ExperienceId = experienceId;
            return View();
        }

        [HttpGet]
        public IActionResult StartExam(int pageNumber,int experienceId)
        {
            ExamQuestionsViewModel model = new ExamQuestionsViewModel();
            var allQuestions = queRepository.GetAll().Where(x=>x.ExperienceId==experienceId).OrderBy(q => q.Id);
            model.QuestionDescription = allQuestions.Skip(pageNumber-1).Take(1).FirstOrDefault().QuestionDescription;
            model.QuestionNumber = allQuestions.First().Id;
            model.ExperienceId = experienceId;
            model.PageNumber = pageNumber;
            return View(model);
        }

    }
}