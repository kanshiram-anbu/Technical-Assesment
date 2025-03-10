using Microsoft.EntityFrameworkCore;
using SampleMVCApplication.Models;
using SampleMVCApplication.Data;

namespace SampleMVCApplication.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDBContext _bookDBContext;
        public BookRepository(BookDBContext bookDBContext)
        {
            _bookDBContext = bookDBContext;
        }

        public async Task<IEnumerable<Books>> FetchBooksAuthorTitleSP()
        {
            var books = await _bookDBContext.Books.FromSqlRaw("EXEC FetchSortedBy_AuthorTitle").ToListAsync();
            return books;
        }

        public async Task<IEnumerable<Books>> FetchBooksPublisherAuthorTitleSP()
        {
            var books = await _bookDBContext.Books.FromSqlRaw("EXEC FetechSortedBy_PublisherAuthorTitle").ToListAsync();

            return books;
        }

        public async Task<IEnumerable<Books>> FetchBooksAuthorTitle()
        {
            return await _bookDBContext.Books
                .OrderBy(b => b.AuthorLastName)
                .ThenBy(b => b.AuthorFirstName)
                .ThenBy(b => b.Title)
                .ToListAsync();
        }

        public async Task<IEnumerable<Books>> FetchBooksPublisherAuthorTitle()
        {
            return await _bookDBContext.Books
                                .OrderBy(b => b.Publisher)
                .ThenBy(b => b.AuthorLastName)
                .ThenBy(b => b.AuthorFirstName)
                .ThenBy(b => b.Title)
                .ToListAsync();
        }

        public async Task<decimal> FetchTotalPrice()
        {
             return await _bookDBContext.Books.SumAsync(s => s.Price);

        }
    }
}
