namespace SubjectManagementSystem.Domain
{
    public class Report : BaseEntity
    {
        public string Description { get; set; }
        public int IdChallenge { get; set; }
        public virtual Challenge Challenge { get; set; }
    }
}