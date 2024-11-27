using System;

namespace MyPortfolio.DAL.Entities
{
    public class Testmonial
    {
        public int TestmonialId { get; set; }
        public string NameSurname { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
