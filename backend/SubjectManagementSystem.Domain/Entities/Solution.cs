using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class Solution : BaseEntity
    {
        public int IdProblem { get; set; }
        public virtual ProblemChallenge Problem { get; set; }
        public int IdTeam { get; set; }
        public virtual Team Team { get; set; }
        
        public virtual List<Stage> Stages { get; set; }
    }
}