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
            
            ViewData["Title"] = "Top 10 books for your book club";
            return View("Show", books);
        }

        public async Task<IActionResult> SummerReads()
        {
            var books = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).ToListAsync();
            
            ViewData["Title"] = "Top 10 summer reads";
            return View("Show", books);
        }

        public async Task<IActionResult> Poetry()
        {
            var books = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 poetry books";
            return View("Show", books);
        }

        public async Task<IActionResult> Anticipated2021()
        {
            var books = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 most highly anticipated books of 2021";
            return View("Show", books);
        }

        public async Task<IActionResult> YogaMindfulness()
        {
            var books = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 books about yoga and mindfulness";
            return View("Show", books);
        }

        public async Task<IActionResult> Quarantine()
        {
            var books = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 most popular books during quarantine";
            return View("Show", books);
        }

        public async Task<IActionResult> Dieting()
        {
            var books = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 books about dieting";
            return View("Show", books);
        }
    }
}
