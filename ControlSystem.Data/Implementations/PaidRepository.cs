using ControlSystem.Core.Interfaces;
using ControlSystem.Data.DAL;

namespace ControlSystem.Data.Implementations
{
    public class PaidRepository<TEntity> : IPaidRepository<TEntity>
        where TEntity : class
    {
        private AppDbContext _context;

        public PaidRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreatePaid(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
        }

        public void UpdatePaid(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
    }
}
