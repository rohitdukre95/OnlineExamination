using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;

namespace OnlineExaminationPortal.Controllers
{
    public class MCQController : Controller
    {
        private readonly IRepository<MCQQuestions> mcqRepository;

        public MCQController(IRepository<MCQQuestions> mcqRepository)
        {
            this.mcqRepository = mcqRepository;
        }
        public IActionResult GetAllMCQQuestions()
        {
            var mcqQuestionsList = mcqRepository.GetAll();

            return View();
        }
    }
}