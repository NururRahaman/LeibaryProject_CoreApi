using Libary.CoreApi.Entities;
using Library.CoreApi.DAL.Interfaceses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.CoreApi.DAL.Repositoryes
{
    public class AuthorRepository : IRepository<Author>
    {
        public Task<object> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Author>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Author> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> Post(Author entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> Put(int id, Author entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
