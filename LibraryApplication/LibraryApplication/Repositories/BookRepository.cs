using LibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApplication.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookManagerContext _context;

        public BookRepository(BookManagerContext context)
        {
            _context = context;
        }

        public BookModel Get(int bookId) => _context.Books.SingleOrDefault(x => x.bookID== bookId);

        public IQueryable<BookModel> GetAllActive() => _context.Books.Where(x => x.bookID != 0);

        public void Add(BookModel book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Update(int bookId, BookModel book)
        {
            var result = _context.Books.SingleOrDefault(x => x.bookID == bookId);
            if (result != null)
            {
                result.name = book.name;
                result.author = book.author;
                result.dateOfPublication = book.dateOfPublication;
                result.description = book.description;

                _context.SaveChanges();
            }
        }

        public void Delete(int bookId)
        {
            var result = _context.Books.SingleOrDefault(x => x.bookID == bookId);
            if (result != null)
            {
                _context.Books.Remove(result);
                _context.SaveChanges();
            }
        }

    }
}
