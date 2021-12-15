using System;
using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public UserTypeEnum? Type { get; set; }
        public virtual string TypeDescription { get { return Type?.GetDescription(); } }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string City { get; set; }
        public StateEnum? State { get; set; }
        public virtual string StateDescription { get { return State?.GetDescription(); } }
        public int? IdInstitution { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual List<UserField> Fields { get; set; }
        public string ProfilePicture { get; set; }
        
        

        //foreign keys from another tables
        public virtual Challenge ChallengeInCharge { get; set; }
        public virtual Challenge ChallengeCreator { get; set; }
        public virtual Team Team { get; set; }

    }
}