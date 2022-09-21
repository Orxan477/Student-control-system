namespace ControlSystem.Core.Models
{
    public class Paids
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subjects Subject { get; set; }
        public int Price { get; set; }
    }
}
