using System;

namespace MyPortfolio.DAL.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Email2 { get; set; } = null!;
        public string Adress { get; set; } = null!;
    }
}
