using ControlSystem.Core.Interfaces.Home;
using ControlSystem.Core.Models;
using ControlSystem.Data.DAL;

namespace ControlSystem.Data.Implementations.Home
{
    public class MonthRepository:GetRepository<Months>, IMonthRepository
    {
        private readonly AppDbContext _context;
        public MonthRepository(AppDbContext context):base(context)
        {
            _context = context;
        }
    }
}
