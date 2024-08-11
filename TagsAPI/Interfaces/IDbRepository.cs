using TagsAPI.Models;

namespace TagsAPI.Interfaces
{
    public interface IDbRepository<T> where T : BaseEntity, new()
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> Get();

        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<bool> Delete(int id);
    }
}
