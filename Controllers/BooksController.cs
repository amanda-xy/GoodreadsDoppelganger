using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoodreadsDoppelganger.Models;

namespace GoodreadsDoppelganger.Controllers
{
    public class BooksController : Controller
    {
        private readonly GoodreadsContext _context;

        public BooksController(GoodreadsContext context)
        {
            _context = context;
        }

        // GET: Books
        public async Task<IActionResult> Index(string searchString)
        {
            var books = _context.Books.Include(b => b.Author).Include(b => b.Reviews).OrderBy(b => b.Title);

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Title.Contains(searchString)).OrderBy(b => b.Title);
            }
            return View(await books.ToListAsync());
        }

        // GET: Books/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var book = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
                return NotFound();

            return View(book);
        }

        //GET
        public async Task<IActionResult> NewReview(int? id)
        {
            if (id == null)
                return NotFound();

            var book = await _context.Books.Include(b => b.Author).Include(b => b.Reviews).FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
                return NotFound();

            ViewBag.BookId = book.Id;
            ViewBag.BookTitle = book.Title;
            ViewBag.BookAuthor = book.Author.FirstName + " " + book.Author.LastName;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewReview([Bind("Rating,Text,HasSpoilers,BookId")] Review review)
        {
            review.PublicationDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction("ConfirmationReview", new { id = review.Id});
            }
            return View(review);
        }

        public async Task<IActionResult> ConfirmationReview(int? id)
        {
            if (id == null)
                return NotFound();

            var review = await _context.Reviews.Include(r => r.Book).FirstOrDefaultAsync(r => r.Id == id);
            if (review == null)
                return NotFound();

            return View(review);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "Id");
            PopulateAuthorsDropDownList();
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,NumberOfPages,ImageUrl,Genre,AuthorId,PublicationDate")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ConfirmationCreated), new { id = book.Id });
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "Id", book.AuthorId);
            return View(book);
        }

        public async Task<IActionResult> ConfirmationCreated(int? id)
        {
            if (id == null)
                return NotFound();

            var book = await _context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
                return NotFound();

            return View(book);
        }


        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var book = await _context.Books.FindAsync(id);
            var book = await _context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            PopulateAuthorsDropDownList();
            return View(book);
        }

        private void PopulateAuthorsDropDownList(object selectedAuthor = null)
        {
            var authorsQuery = from a in _context.Authors
                                   orderby a.LastName
                                   select a;
            ViewBag.Author = new SelectList(authorsQuery.AsNoTracking(), "Id", "FullName", selectedAuthor);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,NumberOfPages,ImageUrl,Rating,Genre,AuthorId,PublicationDate")] Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(ConfirmationEdited), new { id = book.Id });
            }
            ViewData["AuthorId"] = new SelectList(_context.Authors, "Id", "Id", book.AuthorId);
            ViewData["Genres"] = new SelectList(GetGenres(), "Genre", "Genre", book.Genre);
            return View(book);
        }

        public async Task<IActionResult> ConfirmationEdited(int? id)
        {
            if (id == null)
                return NotFound();

            var book = await _context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            if (book == null)
                return NotFound();

            return View(book);
        }

        private IEnumerable<Genre> GetGenres()
        {
            return Enum.GetValues(typeof(Genre)).Cast<Genre>();
        }


        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.Author)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ConfirmationDeleted));
        }

        public IActionResult ConfirmationDeleted()
        {
            return View();
        }

        private bool BookExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }
    }
}
