using Microsoft.AspNetCore.Mvc;
using SampleMVCApplication.Models;
using SampleMVCApplication.Services;

namespace SampleMVCApplication.Controllers
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetBooksPublisherAuthorTitle")]
        public async Task<IActionResult> GetBooksPublisherAuthorTitle()
        {
            try
            {
                var books = await _bookService.FetchBooksPublisherAuthorTitle();
                return Ok(books);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetBooksAuthorTitle")]
        public async Task<IActionResult> GetBooksAuthorTitle()
        {
            try
            {
                var books = await _bookService.FetchBooksAuthorTitle();
                return Ok(books);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetBooksPublisherAuthorTitleSP")]
        public async Task<IActionResult> GetBooksPublisherAuthorTitleSP()
        {
            try
            {
                var books = await _bookService.FetchBooksPublisherAuthorTitleSP();
                return Ok(books);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetBooksAuthorTitleSP")]
        public async Task<IActionResult> GetBooksAuthorTitleSP()
        {
            try
            {
                var books = await _bookService.FetchBooksAuthorTitleSP();
                return Ok(books);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetTotalPrice")]
        public async Task<IActionResult> GetTotalPrice()
        {
            try
            {
                var tot = await _bookService.FetchTotalPrice();
                return Ok(tot);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }


    }
}
