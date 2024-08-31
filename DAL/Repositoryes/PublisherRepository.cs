using Libary.CoreApi.Entities;
using Library.CoreApi.DAL.Interfaceses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.CoreApi.DAL.Repositoryes
{
    public class PublisherRepository : IRepository<Publisher>
    {
        public Task<object> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Publisher>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Publisher> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> Post(Publisher entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<object> Put(int id, Publisher entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
