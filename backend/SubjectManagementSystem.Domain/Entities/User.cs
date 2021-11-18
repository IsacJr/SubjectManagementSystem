using System;
using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public UserTypeEnum Type { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        public Institution Institution { get; set; }
        public List<Field> Field { get; set; }

        public string ProfilePicture { get; set; }

    }
}