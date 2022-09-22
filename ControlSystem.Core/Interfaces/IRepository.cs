namespace ControlSystem.Core.Interfaces
{
    public interface IRepository<T>
    {
        Task<T> GetAll();
        Task CreatePaid(int id);
        Task UpdatePaid(int id);
    }
}
