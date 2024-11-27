using System;

namespace MyPortfolio.DAL.Entities
{
    public class Experience
    {
        public int ExperienceId { get; set; }
        public string Head { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Date { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
