using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class ProblemChallenge : BaseEntity
    {
        public string Code { get; set; }
        public string Detail { get; set; }
        // public List<Team> Team { get; set; }
        public List<User> Specialist { get; set; }

    }
}