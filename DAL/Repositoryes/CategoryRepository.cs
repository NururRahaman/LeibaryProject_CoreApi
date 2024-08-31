using Libary.CoreApi.Entities;
using Library.CoreApi.DAL.Interfaceses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.CoreApi.DAL.Repositoryes
{
    public class CategoryRepository : IRepository<Category>
    {
        public Task<object> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Category>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Category> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> Post(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> Put(int id, Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
