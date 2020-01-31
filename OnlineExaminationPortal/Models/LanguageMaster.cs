using OnlineExaminationPortal.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.Models
{
    public class LanguageMaster : BaseEntity
    {       
        public int LanguageId { get; set; }
        public string Language { get; set; }        
    }
}
