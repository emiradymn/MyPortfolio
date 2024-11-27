using System;

namespace MyPortfolio.DAL.Entities
{
    public class About
    {
        public int AboutId { get; set; }
        public string Title { get; set; } = null!;
        public string SubDescription { get; set; } = null!;
        public string Details { get; set; } = null!;
    }
}
