using ControlSystem.Core.Interfaces.Home;

namespace ControlSystem.Core.Interfaces
{
    public interface IUnitOfWork
    {
        public IPaidRepository PaidRepository { get; }
        public ISubjectRepository SubjectRepository { get; }
        //public ISettingRepository SettingRepository { get; }
        public IMonthRepository MonthRepository { get; }
        Task SaveChangesAsync();
    }
}
