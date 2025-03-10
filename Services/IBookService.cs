using SampleMVCApplication.Models;

namespace SampleMVCApplication.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Books>> FetchBooksPublisherAuthorTitle();
        Task<IEnumerable<Books>> FetchBooksAuthorTitle();
        Task<IEnumerable<Books>> FetchBooksPublisherAuthorTitleSP();
        Task<IEnumerable<Books>> FetchBooksAuthorTitleSP();
        Task<Decimal> FetchTotalPrice();
    }
}
