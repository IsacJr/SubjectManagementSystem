namespace SubjectManagementSystem.Domain
{
    public class Stage : BaseEntity
    {
        public string Description { get; set; }
        public string Link { get; set; }
        public int IdSolution { get; set; }
        public virtual Solution Solution { get; set; }
    }
}