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

            modelBuilder.Entity<Question>().HasData(
                     new Question
                     {
                         Id = 1,
                         QuestionDescription = "Write a program for print given number is even or odd.",
                         Marks = 4,
                         ExperienceId = 1,
                         IsEnabled = true,
                         CreatedBy = 1,
                         CreatedOn = DateTime.Now,
                         IsActive = true,
                         LastUpdatedBy = 1,
                         LastUpdatedOn = DateTime.Now
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
        }
    }
}
