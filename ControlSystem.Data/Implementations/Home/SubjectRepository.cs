using ControlSystem.Core.Interfaces.Home;
using ControlSystem.Core.Models;
using ControlSystem.Data.DAL;

namespace ControlSystem.Data.Implementations.Home
{
    public class SubjectRepository:GetRepository<Subjects>, ISubjectRepository
    {
        private readonly AppDbContext _context;
        public SubjectRepository(AppDbContext context):base(context)
        {
            _context = context;
        }
    }
}
