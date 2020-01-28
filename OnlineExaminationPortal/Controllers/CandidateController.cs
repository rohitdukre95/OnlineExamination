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

        public CandidateController(IRepository<CandidateAddEditViewModel> candidateRepository, IRepository<Experience> expRepository)
        {
            this.candidateRepository = candidateRepository;
            this.expRepository = expRepository;
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
    }
}