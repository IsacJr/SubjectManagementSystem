using System;

namespace SubjectManagementSystem.Domain
{
    public class Classroom : BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Schedule { get; set; }
        public string Room { get; set; }
        public User Professor { get; set; }
        public int Year { get; set; }
        // public string Semester { get; set; }
        public int Spot { get; set; }
        public string ClassPlan { get; set; }
        public Subject Subject { get; set; }

    }
}