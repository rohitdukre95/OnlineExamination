using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public IActionResult DeletePosition(int id)
        {
            Position position = null;
            if (id != 0)
            {
                position = posRepository.Get(id);
            }

            return View(position);
        }

        //[HttpPost]
        //public IActionResult DeletePosition(int id)
        //{
        //    Position position = posRepository.Get(id);
        //    if (position != null)
        //    {
        //        position.IsActive = false;
        //        posRepository.Update(position);
        //    }

        //    return RedirectToAction("Index");
        //}
    }
}