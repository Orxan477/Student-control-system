using ControlSystem.Core.Interfaces.Home;
using ControlSystem.Core.Models;

namespace ControlSystem.Core.Interfaces
{
    public interface IUnitOfWork
    {
        public IPaidRepository PaidRepository { get; }
        public ISubjectRepository SubjectRepository { get; }
        public ISettingRepository SettingRepository { get; }
        public IMonthRepository MonthRepository { get; }
        public IPaidUpdateRepository<Paids> PaidUpdateRepository{get;}
        Task SaveChangesAsync();
    }
}
