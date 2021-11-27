namespace SubjectManagementSystem.Domain
{
    public class Report : BaseEntity
    {
        public string Description { get; set; }
        public int IdChallenge { get; set; }
        public virtual Challenge Challenge { get; set; }
        public int IdAuthor { get; set; }
        public virtual User Author { get; set; }
    }
}