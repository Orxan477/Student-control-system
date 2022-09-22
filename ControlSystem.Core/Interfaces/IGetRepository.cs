namespace ControlSystem.Core.Interfaces
{
    public interface IGetRepository<TEntity>
    {
        Task<List<TEntity>> GetAll();
        Task CreatePaid(TEntity entity);
        void UpdatePaid(TEntity entity);
    }
}
