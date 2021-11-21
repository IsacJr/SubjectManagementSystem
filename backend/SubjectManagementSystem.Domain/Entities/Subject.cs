namespace SubjectManagementSystem.Domain
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Syllabus { get; set; }
        public EducationLevelEnum Level { get; set; }
        public int IdField { get; set; }
        public virtual Field Field { get; set; }

    }
}