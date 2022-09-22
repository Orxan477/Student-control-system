using ControlSystem.Core.Interfaces;

namespace ControlSystem.Data.Implementations
{
    public class Repository<T> : IRepository<T>
        where T : class
    {
        public Task<T> GetAll()
        {
            throw new NotImplementedException();
        }
        public Task CreatePaid(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePaid(int id)
        {
            throw new NotImplementedException();
        }
    }
}
