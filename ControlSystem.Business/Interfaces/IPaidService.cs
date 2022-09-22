using ControlSystem.Business.ViewModels.Price;

namespace ControlSystem.Business.Interfaces
{
    public interface IPaidService
    {
        Task<bool> CreatePaid(int id);
        Task<PriceVM> GetPaid(int id);
        Task<bool> UpdatePaid(int id, PriceVM price);
    }
}
