using ControlSystem.Core.Interfaces.Home;
using ControlSystem.Core.Models;
using ControlSystem.Data.DAL;

namespace ControlSystem.Data.Implementations.Home
{
    public class SettingRepository:GetRepository<Setting>, ISettingRepository
    {
        private readonly AppDbContext _context;
        public SettingRepository(AppDbContext context):base(context)
        {
            _context = context;
        }
    }
}
