using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ePortfolio.Models;

namespace ePortfolio.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                if(context.Skills.Any())
                {
                    return;
                }

                context.Skills.AddRange(
                    new Skill
                    {
                        SkillNo = 1,
                        Name = "Organising yourself and your time",
                        Category = SkillCategories.Learning,
                        Level = SkillLevels.High,
                        Priority = SkillLevels.Low
                    },
                    new Skill
                    {
                        SkillNo = 2,
                        Name = " Note taking",
                        Category = SkillCategories.Learning,
                        Level = SkillLevels.High,
                        Priority = SkillLevels.Low
                    },
                    new Skill
                    {
                        SkillNo = 3,
                        Name = "Gathering information from journals/books",
                        Category = SkillCategories.Learning,
                        Level = SkillLevels.High,
                        Priority = SkillLevels.Low
                    },
                    new Skill
                    {
                        SkillNo = 4,
                        Name = "Gathering information from Internet/databases",
                        Category = SkillCategories.Learning,
                        Level = SkillLevels.High,
                        Priority = SkillLevels.Low
                    },
                    new Skill
                    {
                        SkillNo = 5,
                        Name = "Making judgements about accuracy and relevance of any information found",
                        Category = SkillCategories.Learning,
                        Level = SkillLevels.High,
                        Priority = SkillLevels.Low
                    },
                    new Skill
                    {
                        SkillNo = 6,
                        Name = "Revising and examination techniques",
                        Category = SkillCategories.Learning,
                        Level = SkillLevels.High,
                        Priority = SkillLevels.Low
                    },
                    new Skill
                    {
                        SkillNo = 7,
                        Name = "Writing, using the correct grammar, punctuation and spelling",
                        Category = SkillCategories.Communication,
                        Level = SkillLevels.High,
                        Priority = SkillLevels.Low
                    },
                   new Skill
                   {
                       SkillNo = 8,
                       Name = " Structuring reports and essays",
                       Category = SkillCategories.Communication,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 9,
                       Name = "Using the Harvard referencing systems",
                       Category = SkillCategories.Communication,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 10,
                       Name = " Making a presentation",
                       Category = SkillCategories.Communication,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 11,
                       Name = "Working with others in a group",
                       Category = SkillCategories.Teamwork,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 12,
                       Name = " Taking part in discussions",
                       Category = SkillCategories.Teamwork,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 13,
                       Name = "Negotiating and assertiveness",
                       Category = SkillCategories.Teamwork,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 14,
                       Name = " Storing/copying files on a computer",
                       Category = SkillCategories.IT,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 15,
                       Name = "Producing documents using Word",
                       Category = SkillCategories.IT,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 16,
                       Name = "Producing slides using Powerpoint",
                       Category = SkillCategories.IT,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 17,
                       Name = "Using email",
                       Category = SkillCategories.IT,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 18,
                       Name = "Understanding numbers, measurements and units",
                       Category = SkillCategories.Numeracy,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 19,
                       Name = "Doing calculations and routine mathematics",
                       Category = SkillCategories.Numeracy,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 20,
                       Name = "Problem Solving",
                       Category = SkillCategories.ProblemSolving,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   },
                   new Skill
                   {
                       SkillNo = 21,
                       Name = "Coping with pressure",
                       Category = SkillCategories.ProblemSolving,
                       Level = SkillLevels.High,
                       Priority = SkillLevels.Low
                   });

                context.SaveChanges();
            }
        }
    }
}
