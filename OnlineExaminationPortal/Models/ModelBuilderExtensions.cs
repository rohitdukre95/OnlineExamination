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
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        Name = "Mary",
                        Department = Dept.IT,
                        Email = "mary@pragimtech.com"
                    },
                    new Employee
                    {
                        Id = 2,
                        Name = "John",
                        Department = Dept.HR,
                        Email = "john@pragimtech.com"
                    }
                );
            modelBuilder.Entity<Experience>().HasData(
                   new Experience
                   {
                       Id = 1,
                       ExperienceDescription = "< 2",
                       CreatedBy = 1,
                       CreatedOn = DateTime.Now,
                       ExperienceId = 1,
                       IsActive = true,
                       LastUpdatedBy = 1,
                       LastUpdatedOn = DateTime.Now
                            

                   },
                   new Experience
                   {
                       Id = 2,
                       ExperienceDescription = "2 OR < 4",
                       CreatedBy = 1,
                       CreatedOn = DateTime.Now,
                       ExperienceId = 2,
                       IsActive = true,
                       LastUpdatedBy = 1,
                       LastUpdatedOn = DateTime.Now

                   },
                    new Experience
                    {
                        Id = 3,
                        ExperienceDescription = "4 OR < 6",
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        ExperienceId = 3,
                        IsActive = true,
                        LastUpdatedBy = 1,
                        LastUpdatedOn = DateTime.Now,
                       
                    }
               );

           
            modelBuilder.Entity<Position>().HasData(
                    new Position
                    {
                        Id=1,
                       PositionDescription="Trainee Software Developer",
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        IsActive = true,
                        LastUpdatedBy = 1,
                        LastUpdatedOn = DateTime.Now
                    },
                     new Position
                     {
                         Id=2,
                         PositionDescription = "Software Developer",
                         CreatedBy = 1,
                         CreatedOn = DateTime.Now,
                         IsActive = true,
                         LastUpdatedBy = 1,
                         LastUpdatedOn = DateTime.Now
                     }
               );
            modelBuilder.Entity<LanguageMaster>().HasData(
                 new LanguageMaster
                 {
                     Id = 1,
                     LanguageId = 51,
                     Language = "C#",
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now,
                     IsActive = true,
                     LastUpdatedBy = 1,
                     LastUpdatedOn = DateTime.Now
                 },
                 new LanguageMaster
                 {
                     Id = 2,
                     LanguageId = 50,
                     Language = "C",
                     CreatedBy = 1,
                     CreatedOn = DateTime.Now,
                     IsActive = true,
                     LastUpdatedBy = 1,
                     LastUpdatedOn = DateTime.Now
                 },
                    new LanguageMaster
                    {
                        Id = 3,
                        LanguageId = 54,
                        Language = "C++",
                        CreatedBy = 1,
                        CreatedOn = DateTime.Now,
                        IsActive = true,
                        LastUpdatedBy = 1,
                        LastUpdatedOn = DateTime.Now
                    },
                  new LanguageMaster
                  {
                      Id = 4,
                      LanguageId = 62,
                      Language = "Java",
                      CreatedBy = 1,
                      CreatedOn = DateTime.Now,
                      IsActive = true,
                      LastUpdatedBy = 1,
                      LastUpdatedOn = DateTime.Now
                  },
                  new LanguageMaster
                  {
                      Id = 5,
                      LanguageId = 71,
                      Language = "Python",
                      CreatedBy = 1,
                      CreatedOn = DateTime.Now,
                      IsActive = true,
                      LastUpdatedBy = 1,
                      LastUpdatedOn = DateTime.Now
                  }
            );
           
        }
    }
}
