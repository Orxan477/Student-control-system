using System.Linq.Expressions;

namespace ControlSystem.Core.Interfaces
{
    public interface IGetRepository<TEntity>
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> Get(Expression<Func<TEntity, bool>> exp);
    }
}
