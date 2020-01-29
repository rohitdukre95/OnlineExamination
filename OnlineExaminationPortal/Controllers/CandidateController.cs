using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using NLog;
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
        private readonly ILogger<CandidateController> logger;

        public CandidateController(IRepository<CandidateAddEditViewModel> candidateRepository, IRepository<Experience> expRepository, ILogger<CandidateController> logger)
        {
            this.candidateRepository = candidateRepository;
            this.expRepository = expRepository;
            this.logger = logger;
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
                var candidateRegConfirmationLink = Url.Action("Candidate", "CheckCandidateDetailsToStartExam", new { }, Request.Scheme);

                logger.Log(Microsoft.Extensions.Logging.LogLevel.Warning, candidateRegConfirmationLink);
                try
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    message.From = new MailAddress("rohit.dukre@atidan.com");
                    message.To.Add(new MailAddress(model.Email));
                    message.Subject = "Link to start online exam";
                    message.IsBodyHtml = true; //to make message body as html  
                    message.Body ="<h1>Click on below link to start your online coding exam<br/>"+candidateRegConfirmationLink+" </h1>";
                    smtp.Port = 587;
                    smtp.Host = "smtp.outlook.com"; //for outlook host  
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("rohit.dukre@atidan.com", "R0h!t@123");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                }
                catch (Exception ex) { }
                return View("SubmitCandidateDetails");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult CheckCandidateDetailsToStartExam()
        {
            return View();
        }
    }
}