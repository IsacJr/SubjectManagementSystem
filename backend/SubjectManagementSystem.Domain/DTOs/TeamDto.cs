using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class TeamDto
    {
        public Team Team { get; set; }
        public List<int> IdUserList { get; set; }
    }
}