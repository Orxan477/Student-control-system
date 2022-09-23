namespace ControlSystem.Business.Interfaces
{
    public interface IExamOfWork
    {
        public IPaidService PaidService { get; }
        public IHomeService HomeService { get; }
    }
}
