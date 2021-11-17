namespace SubjectManagementSystem.Domain
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Syllabus { get; set; }
        // public string Level { get; set; }
        // public Area Area { get; set; }

    }
}