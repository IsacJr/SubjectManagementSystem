using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class Team : BaseEntity
    {
        public string Code { get; set; }
        public List<User> Members { get; set; }
        public List<User> Mentors { get; set; }
        public string Solution { get; set; }
    }
}