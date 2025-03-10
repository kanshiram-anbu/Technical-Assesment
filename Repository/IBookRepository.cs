using SampleMVCApplication.Models;

namespace SampleMVCApplication.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Books>> FetchBooksAuthorTitle();
        Task<IEnumerable<Books>> FetchBooksPublisherAuthorTitle();
        Task<IEnumerable<Books>> FetchBooksAuthorTitleSP();
        Task<IEnumerable<Books>> FetchBooksPublisherAuthorTitleSP();
        Task<decimal> FetchTotalPrice();
    }
}
