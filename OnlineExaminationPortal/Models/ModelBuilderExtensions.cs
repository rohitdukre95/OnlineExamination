using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationPortal.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CandidateStatus>().HasData(
                    new CandidateStatus
                    {
                        Id = 1,
                        Status="Candidate Registered",
                        CreatedBy=1,
                        CreatedOn=DateTime.Now,
                        LastUpdatedBy=1,
                        LastUpdatedOn=DateTime.Now,
                        IsActive=true
                    },
                    new CandidateStatus
                    {
                        Id = 2,
                       Status="Allowed for Exam",
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        LastUpdatedBy = 1,
                        LastUpdatedOn = DateTime.Now,
                        IsActive = true
                    },
                     new CandidateStatus
                     {
                         Id = 3,
                         Status = "Exam In Progress",
                         CreatedBy = 1,
                         CreatedOn = DateTime.Now,
                         LastUpdatedBy = 1,
                         LastUpdatedOn = DateTime.Now,
                         IsActive = true
                     },
                      new CandidateStatus
                      {
                          Id = 4,
                          Status = "Exam Completed",
                          CreatedBy = 1,
                          CreatedOn = DateTime.Now,
                          LastUpdatedBy = 1,
                          LastUpdatedOn = DateTime.Now,
                          IsActive = true
                      }
                );
            
        }
    }
}
