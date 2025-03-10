using Microsoft.EntityFrameworkCore;
using SampleMVCApplication.Data;
using SampleMVCApplication.Models;
using SampleMVCApplication.Repository;

namespace SampleMVCApplication.Services
{
    public class BookService : IBookService 
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {  
            _bookRepository = bookRepository; 
        }

        public async Task<IEnumerable<Books>> FetchBooksAuthorTitleSP()
        {
            return await _bookRepository.FetchBooksAuthorTitleSP();
        }

        public async Task<IEnumerable<Books>> FetchBooksPublisherAuthorTitleSP()
        {
            return await _bookRepository.FetchBooksPublisherAuthorTitleSP();
        }

        public async Task<IEnumerable<Books>> FetchBooksAuthorTitle()
        {
            return await _bookRepository.FetchBooksAuthorTitle();
        }

        public async Task<IEnumerable<Books>> FetchBooksPublisherAuthorTitle()
        {
            return await _bookRepository.FetchBooksPublisherAuthorTitle();
        }

        public async Task<decimal> FetchTotalPrice()
        {
            return await _bookRepository.FetchTotalPrice();
        }
    }
}
