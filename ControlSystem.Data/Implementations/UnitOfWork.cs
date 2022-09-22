using ControlSystem.Core.Interfaces;
using ControlSystem.Core.Interfaces.Home;
using ControlSystem.Core.Models;
using ControlSystem.Data.DAL;
using ControlSystem.Data.Implementations.Home;

namespace ControlSystem.Data.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        private PaidRepository _paidRepository;
        private SettingRepository _settingRepository;
        private SubjectRepository _subjectRepository;
        private MonthRepository _monthRepository;
        private PaidUpdateRepository<Paids> _paidUpdateRepository;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IPaidRepository PaidRepository => _paidRepository?? new PaidRepository(_context);

        public ISubjectRepository SubjectRepository => _subjectRepository ?? new SubjectRepository(_context);

        public ISettingRepository SettingRepository => _settingRepository ?? new SettingRepository(_context);


        public IMonthRepository MonthRepository => _monthRepository ?? new MonthRepository(_context);

        public IPaidUpdateRepository<Paids> PaidUpdateRepository => _paidUpdateRepository ?? new PaidUpdateRepository<Paids>(_context);

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
