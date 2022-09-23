namespace ControlSystem.Business.Interfaces
{
    internal interface IExamOfWork
    {
        public IPaidService PaidService { get; }
        public IHomeService HomeService { get; }
    }
}
