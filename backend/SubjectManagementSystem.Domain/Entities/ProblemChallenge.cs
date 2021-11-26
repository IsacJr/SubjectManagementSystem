using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class ProblemChallenge : BaseEntity
    {
        public string Code { get; set; }
        public string Detail { get; set; }
        public int IdChallenge { get; set; }
        public virtual Challenge Challenge { get; set; }
        public int? IdTeam { get; set; }
        public virtual Team Team { get; set; }

    }
}