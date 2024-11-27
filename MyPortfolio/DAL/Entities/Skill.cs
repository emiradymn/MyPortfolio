using System;

namespace MyPortfolio.DAL.Entities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Title { get; set; } = null!;
        public int Value { get; set; }
    }
}
