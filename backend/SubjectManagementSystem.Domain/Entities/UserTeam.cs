namespace SubjectManagementSystem.Domain
{
    public class UserTeam : BaseEntity
    {
        public int IdUser { get; set; }
        public virtual User User { get; set; }
        public int IdTeam { get; set; }
        public virtual Team Team { get; set; }
    }
}