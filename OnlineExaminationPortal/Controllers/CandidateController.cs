using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;
using OnlineExaminationPortal.ViewModels;

namespace OnlineExaminationPortal.Controllers
{
    [AllowAnonymous]
    public class CandidateController : Controller
    {
        private readonly IRepository<CandidateAddEditViewModel> candidateRepository;
        private readonly IRepository<Experience> expRepository;
        private readonly AppDbContext context;

        public CandidateController(IRepository<CandidateAddEditViewModel> candidateRepository, IRepository<Experience> expRepository, AppDbContext context)
        {
            this.candidateRepository = candidateRepository;
            this.expRepository = expRepository;
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AddCandidate()
        {
            CandidateAddEditViewModel model = new CandidateAddEditViewModel();
            var expList = expRepository.GetAll();
            model.ExperienceList = expList.Select(r => new SelectListItem
            {
                Text = r.ExperienceDescription,
                Value = r.ExperienceId.ToString()
            }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddCandidate(CandidateAddEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                CandidateAddEditViewModel candidate = new CandidateAddEditViewModel
                {
                    Name = model.Name,
                    Email = model.Email,
                    DateOfBirth = model.DateOfBirth,
                    Mobile = model.Mobile,
                    CurrentCompany = model.CurrentCompany,
                    ExperienceId = model.ExperienceId,
                    CreatedBy = 1,
                    CreatedOn = DateTime.Now,
                    IsActive = true,
                    LastUpdatedBy=1,
                    LastUpdatedOn=DateTime.Now
                };

                candidateRepository.Insert(candidate);
                return RedirectToAction("index","home");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult CheckCandidateDetailsToStartExam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckCandidateDetailsToStartExam(CheckCandidateDetailsToStartExamViewModel model)
        {
            if (ModelState.IsValid)
            {
                Candidate candidate = null;
                if (model.Email != "")
                {
                    candidate = context.Candidates.Where(can => (can.Email.Trim().Equals(model.Email.Trim())) || (can.Mobile.Trim()==model.Mobile.Trim())).FirstOrDefault();
                }
                if(candidate != null)
                { 
                    return RedirectToAction("index", "exam");
                }
            }

            return RedirectToAction("CheckCandidateDetailsToStartExam", "candidate");
        }
    }
}