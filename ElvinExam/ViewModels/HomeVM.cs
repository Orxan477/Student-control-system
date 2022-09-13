using ElvinExam.Models;

namespace ElvinExam.ViewModels
{
    public class HomeVM
    {
        public List<Subjects> Subjects { get; set; }
        public List<Paids> Paids { get; set; }
        public List<Months> Months { get; set; }
    }
}
