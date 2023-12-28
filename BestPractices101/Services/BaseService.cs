using BaseProject.Entity;
using BestPractices101.Entity;
using BestPractices101.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BestPractices101.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public BaseService(AppDbContext context)
        {
            _context = context;
        }

        public virtual async Task<T> AddAsync(T entity, string userName)
        {
            if (userName.IsNullOrEmpty() || entity == null)
                throw new ArgumentNullException(nameof(userName));

            entity.UserIn = userName;

            _context.Add(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);

            return entity;
        }

        public virtual async Task DeleteAsync(T entity, string? userName)
        {
            ArgumentNullException.ThrowIfNull(entity);

            if (!userName.IsNullOrEmpty())
                entity.UserIn = userName;

            _context.Remove(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(int take = 0, int skip = 0)
        {
            var entities = new List<T>();
            entities = await _context.Set<T>().OrderByDescending(p => p.CreatedDate).Skip(skip).Take(take).ToListAsync().ConfigureAwait(false);

            return entities;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = new List<T>();
            entities = await _context.Set<T>().OrderByDescending(p => p.CreatedDate).ToListAsync().ConfigureAwait(false);

            return entities;
        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _context.Set<T>()
                .FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);

            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity, string userName)
        {
            if (userName.IsNullOrEmpty() || entity == null)
                throw new ArgumentNullException(nameof(userName));

            entity.UserUpd = userName;

            _context.Update(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);

            return entity;
        }
    }
}
