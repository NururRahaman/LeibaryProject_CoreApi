using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.CoreApi.DAL.Interfaceses
{
    public interface IRepository<TEntity>where TEntity : class
    {
        Task<IEnumerable<TEntity>> Get();
        Task<TEntity> Get(int id);
        Task<object>Post(TEntity entity);
        Task<object>Put (int id ,TEntity entity);
        Task<object>Delete(int id);


    }
}
