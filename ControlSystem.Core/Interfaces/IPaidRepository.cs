namespace ControlSystem.Core.Interfaces
{
    public interface IPaidRepository<TEntity>
    {
        Task CreatePaid(TEntity entity);
        void UpdatePaid(TEntity entity);
    }
}
