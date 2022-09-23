using ControlSystem.Business.Interfaces;
using ControlSystem.Core.Interfaces;

namespace ControlSystem.Business.Implementations
{
    public class ExamOfWork : IExamOfWork
    {
        private readonly PaidService _paidService;
        private readonly HomeService _homeService;
        private IUnitOfWork _unitOfWork;

        public ExamOfWork(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IPaidService PaidService => _paidService ?? new PaidService(_unitOfWork);

        public IHomeService HomeService => _homeService ?? new HomeService(_unitOfWork);
    }
}
