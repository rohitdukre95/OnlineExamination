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
        public List<SelectListItem> ExperienceList { get; set; }
    }
}
