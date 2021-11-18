using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class Challenge : BaseEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public Institution Institution { get; set; }
        public Field Fields { get; set; }
        public string Description { get; set; }
        public List<string> Material { get; set; }
        public StatusEnum Status { get; set; }
        public List<string> Reports { get; set; }
        public User InCharge { get; set; }
    }
}