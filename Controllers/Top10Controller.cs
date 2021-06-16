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
            List<string> titles = new List<string>();
            titles.Add("Girl, Woman, Other");
            titles.Add("The Doors Of Eden");
            titles.Add("The Kite Runner");
            titles.Add("All The Bright Places");
            titles.Add("The Song Of Achilles");
            titles.Add("The Book Thief");
            titles.Add("The Boy Who Followed His Father Into Auschwitz");
            titles.Add("Shadow And Bone");
            titles.Add("Six Of Crows");
            titles.Add("The Fault In Our Stars");

            var books = await _context.Books.Where(b => titles.Contains(b.Title)).Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 books for your book club";
            return View("Show", books);
        }

        public async Task<IActionResult> SummerReads()
        {
            List<string> titles = new List<string>();
            titles.Add("Girl, Woman, Other");
            titles.Add("A Thousand Splendid Suns");
            titles.Add("Dear Edward");
            titles.Add("All The Bright Places");
            titles.Add("The Sun And Her Flowers");
            titles.Add("The Binding");
            titles.Add("The Perks Of Being A Wallflower");
            titles.Add("Looking For Alaska");
            titles.Add("Pride And Prejudice");
            titles.Add("Turtles All The Way Down");

            var books = await _context.Books.Where(b => titles.Contains(b.Title)).Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 summer reads";
            return View("Show", books);
        }

        public async Task<IActionResult> Poetry()
        {
            List<string> titles = new List<string>();
            titles.Add("Sea Prayer");
            titles.Add("Milk And Honey");
            titles.Add("The Sun And Her Flowers");
            titles.Add("Home Body");
            titles.Add("Chlorine Sky");
            titles.Add("Long Way Down");

            var books = await _context.Books.Where(b => titles.Contains(b.Title)).Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 poetry books";
            return View("Show", books);
        }

        public async Task<IActionResult> Anticipated2021()
        {
            List<string> titles = new List<string>();
            titles.Add("Before I Go To Sleep");
            titles.Add("Shadow And Bone");
            titles.Add("Siege And Storm");
            titles.Add("Ruin And Rising");
            titles.Add("A Gathering Of Shadows");
            titles.Add("A Conjuring Of Light");
            titles.Add("A Darker Shade Of Magic");
            titles.Add("The Last Thing He Told Me");
            titles.Add("The Boy Who Followed His Father Into Auschwitz");
            titles.Add("Speaker For The Dead");

            var books = await _context.Books.Where(b => titles.Contains(b.Title)).Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 most highly anticipated books of 2021";
            return View("Show", books);
        }

        public async Task<IActionResult> YogaMindfulness()
        {
            
            List<string> titles = new List<string>();
            titles.Add("Light on Yoga: The Bible of Modern Yoga");
            titles.Add("Yoga for Everyone: 50 Poses For Every Type of Body");
            titles.Add("The Little Book of Being: Practices and Guidance for Uncovering Your Natural Awareness");
            titles.Add("Yoga Body: The Origins of Modern Posture Practice");

            var books = await _context.Books.Where(b => titles.Contains(b.Title)).Include(b => b.Author).Include(b => b.Reviews).ToListAsync();
            ViewData["Title"] = "Top 10 books about yoga and mindfulness";
            return View("Show", books);
        }

        public async Task<IActionResult> Quarantine()
        {
            List<string> titles = new List<string>();
            titles.Add("Ender's Game");
            titles.Add("The Giver");
            titles.Add("The Boy Who Followed His Father Into Auschwitz");
            titles.Add("The Hunger Games");
            titles.Add("Six Of Crows");
            titles.Add("Crooked Kingdom");
            titles.Add("Paper Towns");
            titles.Add("And The Mountains Echoed");
            titles.Add("The Tattooist Of Auschwitz");
            titles.Add("Within Without");

            var books = await _context.Books.Where(b => titles.Contains(b.Title)).Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 most popular books during quarantine";
            return View("Show", books);
        }

        public async Task<IActionResult> Dieting()
        {
            List<string> titles = new List<string>();
            titles.Add("Fast. Feast. Repeat. : The Comprehensive Guide To Delay, Don't Deny");
            titles.Add("The Switch: Ignite Your Metabolism with Intermittent Fasting, Protein Cycling, and Keto");
            titles.Add("The 30-Minute Mediterranean Diet Cookbook: 101 Easy, Flavorful Recipes for Lifelong Health");

            var books = await _context.Books.Where(b => titles.Contains(b.Title)).Include(b => b.Author).Include(b => b.Reviews).ToListAsync();

            ViewData["Title"] = "Top 10 books about dieting";
            return View("Show", books);
        }
    }
}
