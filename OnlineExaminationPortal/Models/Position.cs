using OnlineExaminationPortal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.Models
{
    public class Position : BaseEntity
    {
      
        [Required]
        public string PositionDescription { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
    }
}
