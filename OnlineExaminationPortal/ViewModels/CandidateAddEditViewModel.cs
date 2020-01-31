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
        public List<SelectListItem> ExperienceYearList { get; set; }

        public List<SelectListItem> ExperienceMonthList { get; set; }

        public List<SelectListItem> PositionList { get; set; }
    }
}
