using ControlSystem.Business.Interfaces;
using ControlSystem.Business.ViewModels.Price;
using ControlSystem.Core.Interfaces;
using ControlSystem.Core.Models;

namespace ControlSystem.Business.Implementations
{
    public class PaidService : IPaidService
    {
        private IUnitOfWork _unitOfWork;

        public PaidService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<bool> CreatePaid(int id)
        {
            var subject = await _unitOfWork.SettingRepository.Get(x => x.SubjectId == id);
            if (subject is null) return false;
            Paids newPaid = new Paids()
            {
                SubjectId = id,
                Price = subject.Price
            };
            await _unitOfWork.PaidUpdateRepository.CreatePaid(newPaid);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<PriceVM> GetPaid(int id)
        {
            var subject = await _unitOfWork.SettingRepository.Get(x => x.SubjectId == id);
            if (subject is null) throw new Exception("Not Found");
            PriceVM price = new PriceVM()
            {
                Id = id,
                NewPrice = subject.Price,
            };
            return price;
        }

        public async Task<bool> UpdatePaid(int id, PriceVM price)
        {
            var subject = await _unitOfWork.SettingRepository.Get(x => x.SubjectId == id);
            if (subject is null) return false;
            subject.Price = price.NewPrice;
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
