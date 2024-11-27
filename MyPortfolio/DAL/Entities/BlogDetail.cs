using System;

namespace MyPortfolio.DAL.Entities
{
    public class BlogDetail
    {
        public int BlogDetailId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string Date { get; set; } = null!;
    }
}
