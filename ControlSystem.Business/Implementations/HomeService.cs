using ControlSystem.Business.Interfaces;
using ControlSystem.Business.ViewModels;
using ControlSystem.Core.Interfaces;

namespace ControlSystem.Business.Implementations
{
    public class HomeService : IHomeService
    {
        private IUnitOfWork _unitOfWork;

        public HomeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<HomeVM> AdminView()
        {
            HomeVM model = new HomeVM()
            {
                Subjects = await _unitOfWork.SubjectRepository.GetAll(),
                Settings = await _unitOfWork.SettingRepository.GetAll(),
            };
            return model;
        }

        public async Task<HomeVM> HomeView()
        {
            HomeVM model = new HomeVM()
            {
                Months = await _unitOfWork.MonthRepository.GetAll(),
                Subjects = await _unitOfWork.SubjectRepository.GetAll(),
                Paids = await _unitOfWork.PaidRepository.GetAll(),
            };
            return model;
        }
    }
}
