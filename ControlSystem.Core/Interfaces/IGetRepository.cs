namespace ControlSystem.Core.Interfaces
{
    public interface IGetRepository<TEntity>
    {
        Task<List<TEntity>> GetAll();
    }
}
