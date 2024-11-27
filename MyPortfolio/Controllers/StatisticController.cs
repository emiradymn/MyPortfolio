using System;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        private MyPortfolioContext _context;

        public StatisticController(MyPortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.v1 = _context.Skills.Count();
            ViewBag.v2 = _context.Messages.Count();
            ViewBag.v3 = _context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = _context.Messages.Where(x => x.IsRead == true).Count();
            return View();
        }
    }
}
