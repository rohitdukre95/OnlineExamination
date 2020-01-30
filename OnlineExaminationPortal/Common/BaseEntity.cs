using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
 namespace OnlineExaminationPortal.Common
{
    public class BaseEntity
    {
        /// <summary>
        /// Id for the entity instance.
        /// </summary>
        /// 
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date/time when the entity instance was created
        /// </summary>
        /// 

        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the user id who had created the entity instance.
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets the date/timw when the entity instance was last updated.
        /// </summary>
        public DateTime LastUpdatedOn { get; set; }

        /// <summary>
        /// Gets or sets the user id who has last updated the entity instance.
        /// </summary>
        public int LastUpdatedBy { get; set; }

        public bool IsActive { get; set; }
       
    }
}
