using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Nancy.Json;
using NLog;
using OnlineExaminationPortal.Common;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;
using OnlineExaminationPortal.ViewModels;

namespace OnlineExaminationPortal.Controllers
{
    [Authorize(Roles = "Admin,HR")]
    public class CandidateController : Controller
    {
        private readonly IRepository<Candidate> candidateRepository;
        private readonly IRepository<Experience> expRepository;
        private readonly AppDbContext context;
        private readonly IRepository<Position> posRepository;
        private readonly IRepository<CandidateStatus> canStatusRepository;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ILogger<CandidateController> logger;
     
        public CandidateController(IRepository<Candidate> candidateRepository, IRepository<Experience> expRepository, ILogger<CandidateController> logger, AppDbContext context, IRepository<Position> posRepository,
            IRepository<CandidateStatus> canStatusRepository, SignInManager<ApplicationUser> signInManager)
        {
            this.candidateRepository = candidateRepository;
            this.expRepository = expRepository;
            this.context = context;
            this.posRepository = posRepository;
            this.canStatusRepository = canStatusRepository;
            this.signInManager = signInManager;
            this.logger = logger;
        }
        public IActionResult Index()
        {
            var model = candidateRepository.GetAll().Where(ques => ques.IsActive == true);
            var posList = posRepository.GetAll();
            var candStatusList = canStatusRepository.GetAll();
            foreach (var item in model)
            {
                var pos = posList.Where(x => x.Id == item.PositionId).FirstOrDefault();
                item.Position = pos;
                if (item.CandidateStatus != 0)
                {
                    var status = candStatusList.Where(x => x.Id == item.CandidateStatus).FirstOrDefault();
                    item.StatusString = status.Status;
                }
                else
                {
                    item.StatusString = "";
                }
                switch (item.IsExamCleared)
                {
                    case 0:
                        item.IsExamClearedString = "Fail";
                        break;
                    case 1:
                        item.IsExamClearedString = "Pass";
                        break;
                    case 2:
                        item.IsExamClearedString = "N.A.";
                        break;
                    default:
                        break;
                }

            }
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public ViewResult AddCandidate()
        {
            CandidateAddEditViewModel model = new CandidateAddEditViewModel();
            try
            {
                var expList = expRepository.GetAll();
                var posList = posRepository.GetAll();
                //model.ExperienceList = expList.Select(r => new SelectListItem
                //{
                //    Text = r.ExperienceDescription,
                //    Value = r.ExperienceId.ToString()
                //}).ToList();
                model.ExperienceYearList = StaticData.Year.Select(year => new SelectListItem
                {
                    Text = year.ToString(),
                    Value = year.ToString()
                }).ToList();
                model.ExperienceMonthList = StaticData.Month.Select(month => new SelectListItem
                {
                    Text = month.ToString(),
                    Value = month.ToString()
                }).ToList();
                model.PositionList = posList.Select(r => new SelectListItem
                {
                    Text = r.PositionDescription,
                    Value = r.Id.ToString()
                }).ToList();
            }
            catch(Exception ex)
            {
                logger.LogError($"Error while showing candidate registration page: {ex.StackTrace}");
                ViewBag.ErrorTitle = $"Error Occurred";
                ViewBag.ErrorMessage = $"Error occurred while showing candidate registration page";
                return View("Error");
            }
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult AddCandidate(CandidateAddEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var cand = candidateRepository.GetAll().Where(x => x.Email == model.Email).FirstOrDefault();
                    if (cand != null)
                    {
                        if (cand.Email == model.Email)
                        {
                            ModelState.AddModelError("", "Candidate with provided email address is already exists");
                        }
                        if(cand.Mobile == model.Mobile)
                        {
                            ModelState.AddModelError("", "Candidate with provided mobile number is already exists");
                        }
                        return View(model);
                    }
                    Candidate candidate = new Candidate
                    {
                        Name = model.Name,
                        Email = model.Email,
                        DateOfBirth = model.DateOfBirth,
                        Mobile = model.Mobile,
                        CurrentCompany = model.CurrentCompany,
                        //   ExperienceId = model.ExperienceId,
                        ExperienceYear = model.ExperienceYear,
                        ExperienceMonth = model.ExperienceMonth,
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        IsActive = true,
                        LastUpdatedBy = 1,
                        LastUpdatedOn = DateTime.Now,
                        PositionId = model.PositionId,
                        CandidateStatus = 1
                    };

                    candidateRepository.Insert(candidate);
                }
               
                catch (Exception ex)
                {
                    logger.LogError($"Error while adding candidate: {ex.StackTrace}");
                    ViewBag.ErrorTitle = $"Error adding candidate";
                    ViewBag.ErrorMessage = $"Error while adding new candidate named : {model.Name}";
                    return View("Error");
                }

                if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                {
                    return RedirectToAction("Index", "Candidate");
                }
                TempData["Success"] = "Registration Successful!";            
                return View("SubmitCandidateDetails");              
            }

            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult CheckCandidateDetailsToStartExam(string cid,string tkn)
        {
            if (!String.IsNullOrEmpty(cid) && !String.IsNullOrEmpty(tkn))
            {
                int cId = Convert.ToInt32(Common.Common.Base64Decode(cid));
                var candidate = candidateRepository.Get(cId);
                if (candidate != null)
                {
                    //To decode the token to get the creation time:
                    byte[] data = Convert.FromBase64String(tkn);
                    DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));
                    if (when < DateTime.UtcNow.AddHours(-24))
                    {
                        // too old
                    }
                    if (candidate.Token == tkn && candidate.IsConsumed == 0)
                    {
                        return View();
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Exam Link is Expired";
                        return View("ExamLinkExpired");
                    }
                }
                else
                {
                    logger.LogError($"Candidate not found with Id: {cId}");
                    ViewBag.ErrorTitle = $"Candidate not found";
                    ViewBag.ErrorMessage = $"Candidate not found with ID: {cId}";
                    return View("Error");
                }
            }
            logger.LogError($"Parameters are not valid for the action CheckCandidateDetailsToStartExam of CandidateController");
            ViewBag.ErrorTitle = $"Parameters are not valid";
            ViewBag.ErrorMessage = $"Details provided are not proper to start exam";
            return View("Error");
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult CheckCandidateDetailsToStartExam(CheckCandidateDetailsToStartExamViewModel model)
        {
            if (ModelState.IsValid)
            {
                Candidate candidate = null;
                if (model.Email != "")
                {
                    candidate = context.Candidates.Where(can => (can.Email.Trim().Equals(model.Email.Trim())) && (can.Mobile.Trim()==model.Mobile.Trim())).FirstOrDefault();
                }
                if(candidate != null)
                { 
                    return RedirectToAction("index", "exam",new { positionId=candidate.PositionId,candidateId=candidate.Id});
                }
            }
            ModelState.AddModelError("", "Candidate Details Not Found");
            return View(model);
        }
        [HttpGet]
        public IActionResult SendExamLink(int canId)
        {
            if (canId != 0)
            {
                try
                {
                    var candidate = context.Candidates.Where(x => x.Id == canId).FirstOrDefault();
                    if(candidate!=null)
                    {
                        //creating a unique token containing a time stamp:
                        byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
                        byte[] key = Guid.NewGuid().ToByteArray();
                        string token = Convert.ToBase64String(time.Concat(key).ToArray());
                        //string token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
                        string cid = Common.Common.Base64Encode(canId.ToString());
                        var candidateRegConfirmationLink = Url.Action("CheckCandidateDetailsToStartExam", "Candidate", new { cid = cid,tkn= token }, Request.Scheme);

                        logger.Log(Microsoft.Extensions.Logging.LogLevel.Warning, candidateRegConfirmationLink);
                        MailMessage message = new MailMessage();
                        SmtpClient smtp = new SmtpClient();
                        message.From = new MailAddress("rohit.dukre@atidan.com");
                        message.To.Add(new MailAddress(candidate.Email));
                        message.Subject = "Link to start online exam";
                        message.IsBodyHtml = true; //to make message body as html  
                        message.Body = "<h3>Click on below link to start your online coding exam<br/> "+ candidateRegConfirmationLink + "</h3>";
                        smtp.Port = 587;
                        smtp.Host = "smtp.outlook.com"; //for outlook host  
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("rohit.dukre@atidan.com", "R0h!t@123");
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Send(message);

                        candidate.CandidateStatus = 2;
                        candidate.Token = token;
                        candidate.ExamLink = candidateRegConfirmationLink;
                        candidateRepository.Update(candidate);
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError($"Error while Sending Exam Link: {ex}");
                    ViewBag.ErrorTitle = $"Error while Sending Exam Link";
                    ViewBag.ErrorMessage = $"Error while Sending Exam Link for Candidate Id: {canId}";
                    return View("Error");
                }              
            }
            return View("ExamLinkSuccess");
        }

        public IActionResult EditCandidate(string data)
        {
            var editData = new JavaScriptSerializer().Deserialize<string[]>(data);
            Candidate can = candidateRepository.Get(Int32.Parse(editData[0]));
            if (can != null)
            {
                can.Marks = Int32.Parse(editData[1]);
                can.IsExamCleared = Int32.Parse(editData[2]);
                can.CandidateStatus = 5;
                try
                {
                    candidateRepository.Update(can);
                }
                catch(Exception ex)
                {
                    logger.LogError($"Error while Editing Candidate with Id: {Int32.Parse(editData[0])} :{ex}");

                    ViewBag.ErrorTitle = $"Update Error";
                    ViewBag.ErrorMessage = $"Error while Editing Candidate with Id: {Int32.Parse(editData[0])}";
                    return View("Error");
                }
            }
            return Json(new { success = true});
        }
        public IActionResult DeleteCandidate(int id)
        {
            Candidate can = candidateRepository.Get(id);
            if (can != null)
            {
                can.IsActive = false;
                try
                {
                    candidateRepository.Update(can);
                }
                catch (Exception ex)
                {
                    logger.LogError($"Error while Editing Candidate with Id: {id} :{ex}");

                    ViewBag.ErrorTitle = $"Update Error";
                    ViewBag.ErrorMessage = $"Error while Editing Candidate with Id: {id}";
                    return View("Error");
                }
            }
            return Json(new { success = true });
        }
    }
}