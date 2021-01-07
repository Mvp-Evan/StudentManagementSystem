namespace dataAccessLayer.entity
{
    public class StudentEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public string sex { get; set; } 
        public string passwd { get; set; }
        public int classId { get; set; }
    }
}