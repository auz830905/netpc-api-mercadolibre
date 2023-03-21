using System.Linq.Expressions;

namespace NETPC.ApiMercadoLibre.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(string url, Dictionary<string, string>? param = null);
        Task<IList<T>> GetAll(string url, Dictionary<string, string>? param = null);
     //   Task Insert(T entity);
    //    Task InsertRange(IEnumerable<T> entities);
    //    Task Delete(int id);
    //    void DeleteRange(IEnumerable<T> entities);
    //    void Update(T entity);
    }
}
