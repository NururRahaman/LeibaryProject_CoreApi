using Libary.CoreApi.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Library.CoreApi.DAL.Interfaceses
{
    public interface IBookRepository:IRepository<Book>
    {
        IEnumerable<Book> GetBooksByAuthor(int categoryId);
        IEnumerable<Book> GetBooksByPublisher(int publisherId);
        IEnumerable<Book> GetBooksByCategory(int categoryId);
        IEnumerable<Book> SearchBook(string searchString);
        IEnumerable<Book> GetActiveBooks();
        IEnumerable<Book> GetInActiveBooks();
    }
}
