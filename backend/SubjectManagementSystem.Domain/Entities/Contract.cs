namespace SubjectManagementSystem.Domain
{
    public class Contract : BaseEntity
    {
        public int IdChallenge { get; set; }
        public virtual Challenge Challenge { get; set; }
        public int IdClassroom { get; set; }
        public virtual Classroom Classroom { get; set; }
    }
}