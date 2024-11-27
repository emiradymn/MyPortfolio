using System;

namespace MyPortfolio.DAL.Entities
{
    public class ToDoList
    {
        public int ToDoListId { get; set; }
        public string Title { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
