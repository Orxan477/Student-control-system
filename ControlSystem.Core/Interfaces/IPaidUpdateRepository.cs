namespace ControlSystem.Core.Interfaces
{
    public interface IPaidUpdateRepository<TEntity>
    {
        Task CreatePaid(TEntity entity);
        void UpdatePaid(TEntity entity);
    }
}
