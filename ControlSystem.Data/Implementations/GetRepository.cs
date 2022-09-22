using ControlSystem.Core.Interfaces;
using ControlSystem.Data.DAL;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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

        public async Task<TEntity> Get(Expression<Func<TEntity, bool>> exp)
        {
            var model = await _context.Set<TEntity>().Where(exp).FirstOrDefaultAsync();
            return model;
        }

        public async Task<List<TEntity>> GetAll()
        {
            List<TEntity> model=await _context.Set<TEntity>().ToListAsync();
            return model;
        }
    }
}
