using ControlSystem.Core.Models;

namespace ControlSystem.Business.ViewModels
{
    public class HomeVM
    {
        public List<Subjects> Subjects { get; set; }
        public List<Paids> Paids { get; set; }
        public List<Months> Months { get; set; }
        public List<Setting> Settings { get; set; }
    }
}
