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

        public SkillCategories Category { get; set; }

        [StringLength(60), Required]
        public string Name { get; set; }

        public SkillLevels Level { get; set; }

        public SkillLevels Priority { get; set; }

        [StringLength(500), DataType(DataType.MultilineText)]
        public string Evidence { get; set; }
    }
}
