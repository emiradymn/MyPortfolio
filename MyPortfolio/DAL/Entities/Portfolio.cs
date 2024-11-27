using System;

namespace MyPortfolio.DAL.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string Title { get; set; } = null!;
        public string SubTitle { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
