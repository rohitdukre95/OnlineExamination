using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;
using OnlineExaminationPortal.Models;
using OnlineExaminationPortal.Repository;

namespace OnlineExaminationPortal.Controllers
{
    [AllowAnonymous]
    public class PositionController : Controller
    {
        private readonly IRepository<Position> posRepository;

        public PositionController(IRepository<Position> posRepository)
        {
            this.posRepository = posRepository;
        }
        public IActionResult Index()
        {
            var model = posRepository.GetAll().Where(pos => pos.IsActive == true);
            return View(model);
        }
        [HttpPost]
        public JsonResult AddModel(string data)
        {
            var editData = new JavaScriptSerializer().Deserialize<string[]>(data);

            Position pos = new Position{
                CreatedBy = 1,
                CreatedOn = DateTime.Now,
                IsActive = true,
                LastUpdatedBy = 1,
                LastUpdatedOn = DateTime.Now,
                PositionDescription = editData[1]
            };
        
            posRepository.Insert(pos);


            return Json(new { success = true, responseText = "Position Added Successfully." });
        }
        [HttpPost]
        public JsonResult EditModel(string data)
        {
            var editData = new JavaScriptSerializer().Deserialize<string[]>(data);
            Position pos = posRepository.Get(Int32.Parse(editData[0]));
            pos.PositionDescription = editData[1];
            posRepository.Update(pos);

            return Json(new { success = true, responseText = "Position Edited Successfully." });
        }
        [HttpPost]
        public JsonResult DeleteModel(string data)
        {
            var editData = new JavaScriptSerializer().Deserialize<string[]>(data);
            Position pos = posRepository.Get(Int32.Parse(editData[0]));
            posRepository.Delete(pos);

            return Json(new { success = true, responseText = "Position Deleted Successfully." });
        }
    }
}