namespace BestPractices101.Services.Interfaces
{
    public interface IBaseService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(int take=0, int skip=0);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity, string userName);
        Task<T> UpdateAsync(T entity, string userName);
        Task DeleteAsync(T entity, string? userName);
    }
}
