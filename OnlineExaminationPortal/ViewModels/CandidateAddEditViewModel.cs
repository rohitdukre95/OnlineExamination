using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineExaminationPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.ViewModels
{
    public class CandidateAddEditViewModel : Candidate
    {
        public List<SelectListItem> ExperienceYear { get; set; }

        public List<SelectListItem> ExperienceMonth { get; set; }

        public List<SelectListItem> PositionList { get; set; }
    }
}
