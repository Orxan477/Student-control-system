namespace ElvinExam.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public Subjects Subject { get; set; }
        public int Price { get; set; }
    }
}
