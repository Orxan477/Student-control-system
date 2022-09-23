using ControlSystem.Business.ViewModels;

namespace ControlSystem.Business.Interfaces
{
    public interface IHomeService
    {
        Task<HomeVM> AdminView();
        Task<HomeVM> HomeView();
    }
}
