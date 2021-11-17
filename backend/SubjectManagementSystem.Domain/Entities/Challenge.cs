namespace SubjectManagementSystem.Domain
{
    public class Challenge : BaseEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Material { get; set; }
        // public StatusEnum Status { get; set; }
        public string Report { get; set; }
    }
}