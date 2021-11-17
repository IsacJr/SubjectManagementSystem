using System;

namespace SubjectManagementSystem.Domain
{
    public class Classroom
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Schedule { get; set; }
        public string Room { get; set; }
        public User Professor { get; set; }
        public int Year { get; set; }
        public string Semester { get; set; }
    }
}