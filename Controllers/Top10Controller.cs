using GoodreadsDoppelganger.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodreadsDoppelganger.Controllers
{
    public class Top10Controller : Controller
    {
        private readonly GoodreadsContext _context;
        public Top10Controller(GoodreadsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> HighestRatedAsync()
        {
            var books = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).ToListAsync();
            var highestRated = books.OrderByDescending(b => b.Rating).Take(10);
            ViewData["Title"] = "Top 10 highest rated books";
            return View("Show", highestRated);
        }

        public async Task<IActionResult> BookClub()
        {
            var books = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).ToListAsync();
            var bookClub = books.OrderByDescending(b => b.Rating).Take(10);
            ViewData["Title"] = "Top 10 books for your book club";
            return View("Show", bookClub);
        }

        public async Task<IActionResult> SummerReads()
        {
            var books = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).ToListAsync();
            var bookClub = books.OrderByDescending(b => b.Rating).Take(10);
            ViewData["Title"] = "Top 10 summer reads";
            return View("Show", bookClub);
        }
    }
}
