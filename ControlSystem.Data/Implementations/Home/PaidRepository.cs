using ControlSystem.Core.Interfaces.Home;
using ControlSystem.Core.Models;
using ControlSystem.Data.DAL;

namespace ControlSystem.Data.Implementations.Home
{
    public class PaidRepository:GetRepository<Paids>, IPaidRepository
    {
        private readonly AppDbContext _context;
        public PaidRepository(AppDbContext context):base(context)
        {
            _context = context;
        }
    }
}
