using Microsoft.EntityFrameworkCore;
using StackOverflowTagsAPI.Database;
using TagsAPI.Interfaces;
using TagsAPI.Models;

namespace TagsAPI.Services
{
    public abstract class DbRepository<T> : IDbRepository<T> where T: BaseEntity, new()
    {
        protected readonly TagsDbContext _context;
        protected DbSet<T> Entities => _context.Set<T>();
        protected DbRepository(TagsDbContext context)
        {
            _context = context;
        }

        public async virtual Task<T> Get(int id) => await Entities.FindAsync(id);
     
        //getall, polimorfizm
        public async virtual Task<IEnumerable<T>> Get() => await Entities.ToListAsync();
        

        public async virtual Task<T> Add(T entity)
        {
           await Entities.AddAsync(entity);
           await _context.SaveChangesAsync();
           return entity;
        }

        public async virtual Task<T> Update(T entity)
        {
            var e = await Get(entity.Id);
            if (e == null) {
                return null;
            }
             _context.Update(entity);
             await _context.SaveChangesAsync();
            return entity;
        }

        public async virtual Task<bool> Delete(int id)
        {
            var e = await Get(id);
            if (e == null) { return false;}
            Entities.Remove(e);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
