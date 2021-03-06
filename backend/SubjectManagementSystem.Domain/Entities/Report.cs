namespace SubjectManagementSystem.Domain
{
    public class Report : BaseEntity
    {
        public string Description { get; set; }
        public int IdProblemChallenge { get; set; }
        public virtual ProblemChallenge ProblemChallenge { get; set; }
        public int IdAuthor { get; set; }
        public virtual User Author { get; set; }
    }
}