using System;
using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class UserField : BaseEntity
    {
        public int IdUser { get; set; }
        public virtual User User { get; set; }

        public int IdField { get; set; }
        public virtual Field Field { get; set; }

    }
}