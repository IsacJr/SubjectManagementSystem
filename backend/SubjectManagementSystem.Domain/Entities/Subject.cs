namespace SubjectManagementSystem.Domain
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Syllabus { get; set; }
        // public string Level { get; set; }
        public int IdField { get; set; }
        public virtual Field Field { get; set; }

        
        //foreign keys from another tables
        // public virtual Classroom Classroom { get; set; }

    }
}