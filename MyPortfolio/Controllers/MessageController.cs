using System;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class MessageController : Controller
    {
        private MyPortfolioContext _context;

        public MessageController(MyPortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Inbox()
        {
            var values = _context.Messages.ToList();
            return View(values);
        }

        public IActionResult ChangeReadToTrue(int id)
        {
            var message = _context.Messages.Find(id);
            message.IsRead = true;
            _context.SaveChanges();
            return RedirectToAction("Inbox");

        }

        public IActionResult ChangeReadToFalse(int id)
        {
            var message = _context.Messages.Find(id);
            message.IsRead = false;
            _context.SaveChanges();
            return RedirectToAction("Inbox");

        }

        public IActionResult DeleteMessage(int id)
        {
            var message = _context.Messages.Find(id);
            _context.Messages.Remove(message);
            _context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetails(int id)
        {
            var message = _context.Messages.Find(id);
            return View(message);
        }
    }
}
