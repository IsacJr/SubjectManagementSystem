namespace SubjectManagementSystem.Domain
{
    public class Field : BaseEntity
    {
        public string Name { get; set; }
        
        
        //foreign keys from another tables
        // public virtual Subject Subject { get; set; }
        // public virtual Challenge Challenge { get; set; }
    }
}