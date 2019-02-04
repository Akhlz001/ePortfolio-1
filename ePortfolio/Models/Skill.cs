using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ePortfolio.Models
{
    public enum SkillLevels
    {
        High,
        AboveAverage,
        BelowAverage,
        Low,
    }

    public enum SkillCategories
    {
        Learning,
        Communication,
        HarvardReferencing,
        Teamwork,
        IT,
        Numeracy,
        ProblemSolving
    }

    public class Skill
    {
        [Key]
        public int SkillID { get; set; }

        public int SkillNo { get; set; }

        [Display(Name ="Skill Type")]
        public SkillCategories Category { get; set; }

        [StringLength(100), Required, Display(Name="Skill Description")]
        public string Name { get; set; }

        [Display(Name = "Current Level")]
        public SkillLevels Level { get; set; }

        [Display(Name ="Learning Priority")]
        public SkillLevels Priority { get; set; }

        [StringLength(1000), DataType(DataType.MultilineText)]
        public string Evidence { get; set; }
    }
}
