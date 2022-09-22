using ControlSystem.Core.Interfaces;
using ControlSystem.Data.DAL;
using Microsoft.EntityFrameworkCore;

namespace ControlSystem.Data.Implementations
{
    public class GetRepository<TEntity> : IGetRepository<TEntity>
        where TEntity : class
    {
        private AppDbContext _context;

        public GetRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<TEntity>> GetAll()
        {
            List<TEntity> model=await _context.Set<TEntity>().ToListAsync();
            return model;
        }
    }
}
