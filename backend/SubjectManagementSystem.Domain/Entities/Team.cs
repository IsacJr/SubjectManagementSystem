using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class Team : BaseEntity
    {
        public string Code { get; set; }
        public int IdMentor { get; set; }
        public virtual User Mentor { get; set; }
        public string Solution { get; set; }

        
        //foreign key from another table
        public virtual ProblemChallenge ProblemChallenge { get; set; }
    }
}