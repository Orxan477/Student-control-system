using ControlSystem.Core.Interfaces;
using ControlSystem.Data.DAL;
using Microsoft.EntityFrameworkCore;

namespace ControlSystem.Data.Implementations
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<TEntity>> GetAll()
        {
            List<TEntity> model=await _context.Set<TEntity>().ToListAsync();
            return model;
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
