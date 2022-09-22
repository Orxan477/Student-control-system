namespace ControlSystem.Core.Interfaces
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
