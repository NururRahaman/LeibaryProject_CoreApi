using Libary.CoreApi.Entities;
using Library.CoreApi.DAL.Interfaceses;
using Library.CoreApi.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

using System.Linq;
using System.Security.Policy;

namespace Library.CoreApi.DAL.Repositoryes
{
    public class BookRepository : IBookRepository
    {
        private  LibraryContext _db; // Replace YourDbContext with your actual DbContext class

        public BookRepository(LibraryContext context)
        {
            _db = context;
        }
        public async Task<object> Delete(int id)
        {
           var book = await _db.Books.FindAsync(id);
            if(book != null)
            {
                _db.Books.Remove(book);
                await _db.SaveChangesAsync();
            }
            return book;
        }
        public async Task<object> SoftDelete(int id)
        {
            var book = await _db.Books.FindAsync(id);
            if (book != null)
            {
                _db.Books.Remove(book);
                await _db.SaveChangesAsync();
            }
            return null;
        }

        public async Task<IEnumerable<Book>> Get()
        {
            return await _db.Books.ToArrayAsync();
        }

        public async Task<Book> Get(int id)
        {
            var book = await _db.Books.FindAsync(id);
            return book; 

        }

        public IEnumerable<Book> GetActiveBooks()
        {
           var books = from book in _db.Books
                       where book.IsActive == true  
                       select book;
            return books;
        }
        //public IEnumerable<Book> GetInActiveBooks()
        //{
        //    var books = from b in _db.Books
        //                where b.IsActive == false
        //                select b;
        //    return books;
        //}

        public IEnumerable<Book> GetBooksByAuthor(int authorId)
        {
            var books = from b in _db.Books
                        where b.AuthorId == authorId
                        select b;
            return books;
        }

        public IEnumerable<Book> GetBooksByCategory(int categoryId)
        {
            var books = from b in _db.Books
                        where b.CategoryId == categoryId
                        select b;
            return books;
        }

        public IEnumerable<Book> GetBooksByPublisher(int publisherId)
        {
            var books = from b in _db.Books
                        where b.PublisherId == publisherId
                        select b;
            return books;
        }

        public IEnumerable<Book> GetInActiveBooks()
        {
            var books = from b in _db.Books
                        where b.IsActive == false
                        select b;
            return books;
        }

        public async Task<object> Post(Book entity)
        {
          _db.Books.Add(entity);
            await _db.SaveChangesAsync();   
            return entity;

        }

        public async Task<object> Put(Book entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }
        public async Task<object> Put(int id, Book entity)
        {
            var book = _db.Books.Find(id);
            book.BookName= entity.BookName;
            book.AuthorId = entity.AuthorId;
            book.ISBN = entity.ISBN;
            book.NumberOfPage = entity.NumberOfPage;
            book.CategoryId = entity.CategoryId;
            book.PublisherId = entity.PublisherId;
            book.Descrition = entity.Descrition;
            book.Edition = entity.Edition;
            book.ImageUrl = entity.ImageUrl;
            book.IsActive = entity. IsActive;
            book.Language = entity.Language;
            book.Price = entity.Price;
           await _db.SaveChangesAsync();
            return entity;
        }

        public IEnumerable<Book> SearchBook(string searchString)
        {

            var books = from b in _db.Books
                        where b.BookName.ToLower().Contains(searchString.ToLower()) == true
                        select b;
            return books.ToList();
        }
    }
}
