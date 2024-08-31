using Libary.CoreApi.Entities;
using Library.CoreApi.DAL.Interfaceses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;
using System.Threading.Tasks;

namespace Library.CoreApi.Controllers
{
    [Route("api/Book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public IBookRepository _irepo;


        public BookController(IBookRepository repository) 
        {
         _irepo = repository;
        }


        [HttpGet, Route("GetBooks")]
        public async Task<IActionResult> Get()
        {
            var books = await _irepo.Get();
            return Ok(books);
        }


        [HttpGet, Route("GetBooks/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var book = await _irepo.Get(id);
            if (book == null)
            {
                return Content("Can not Found the desired Book.");
            }
            return Ok(book);
        }


        [HttpPost, Route("Post")]
        public async Task<IActionResult> Post( Book book)
        {
            await _irepo.Post(book);
            return Ok(book);
        }
   

        [HttpPut,Route("Put/{id}")]
        public async Task<IActionResult>Put(int id ,Book book)
        {
            await _irepo.Put(id, book); 
            return Ok(book);
        }


        [HttpDelete, Route("DeleteBook/{id}")]
        public async Task<IActionResult>Delete(int id)
        {
            var data = await _irepo.Delete(id);
            if(data != null) 
            {
                return RedirectToRoute("GetBooks");
            }
            return Content("Delete Done.....");
        }

        [HttpGet, Route("SearchBook/{searchString}")]
        public IActionResult SearchByBookName(string searchString)
        {
            var books = _irepo.SearchBook(searchString);
            return Ok(books);
        }

        [HttpGet,Route("GetBooksByCategory/{categoryId}")]
        public IActionResult GetBooksByCategory(int categoryId)
        {
            var books = _irepo.GetBooksByCategory(categoryId);
            if(books != null)
            {
                return Ok(books);
            }
            return Content("Not Found.....");
        }

        [HttpGet, Route("GetBooksByPublisher/{publisherId}")]
        public IActionResult GetBooksByPublisher(int publisherId)
        {
            var books = _irepo.GetBooksByPublisher(publisherId);
            if (books != null)
            {
                return Ok(books);
            }
            return Content("Not Found.....");
        }

        [HttpGet, Route("GetBooksByAuthor/{authorid}")]
        public IActionResult GetBooksByAuthor(int authorid)
        {
            var books = _irepo.GetBooksByAuthor(authorid);
            if (books != null)
            {
                return Ok(books);
            }
            return Content("Not Found.....");
        }

        [HttpGet ,Route("GetActiveBooks")]
        public IActionResult GetActiveBooks()
        {
            var books = _irepo.GetActiveBooks();
            return Ok(books);
        }
        [HttpGet, Route("GetInActiveBooks")]
        public IActionResult GetInActiveBooks()
        {
            var books = _irepo.GetInActiveBooks();
            return Ok(books);
        }
    }
}


