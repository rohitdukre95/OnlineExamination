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
        private readonly IRepository<Question> quesRepository;

        public MCQController(IRepository<MCQQuestions> mcqRepository, IRepository<Question> quesRepository)
        {
            this.mcqRepository = mcqRepository;
            this.quesRepository = quesRepository;
        }
        public IActionResult Index()
        {
            var mcqQuestionsList = mcqRepository.GetAll();

            return View();
        }
    }
}