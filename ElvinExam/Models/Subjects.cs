namespace ElvinExam.Models
{
    public class Subjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Paids> Paids { get; set; }
    }
}
