using System;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.ViewModels
{
    public class CombinedModel
    {
        public IEnumerable<About> Abouts { get; set; } = null!;
        public IEnumerable<Skill> Skills { get; set; } = null!;
        public IEnumerable<Experience> Experiences { get; set; } = null!;
    }
}
