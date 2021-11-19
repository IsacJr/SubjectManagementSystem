using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class Challenge : BaseEntity
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public int IdInstitution { get; set; }
        public virtual Institution Institution { get; set; }
        public int IdField { get; set; }
        public virtual Field Field { get; set; }
        public string Description { get; set; }
        public List<string> Material { get; set; }
        public StatusEnum Status { get; set; }
        public List<string> Reports { get; set; }
        public int IdInCharge { get; set; }
        public virtual User InCharge { get; set; }
        public int IdCreator { get; set; }
        public virtual User Creator { get; set; }
    }
}