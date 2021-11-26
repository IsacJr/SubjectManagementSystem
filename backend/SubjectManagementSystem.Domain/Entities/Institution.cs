using System.Collections.Generic;

namespace SubjectManagementSystem.Domain
{
    public class Institution : BaseEntity
    {
        public string Name { get; set; }
        public string EmployerIdentificationNumber { get; set; }
        public string Code { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public StateEnum State { get; set; }
        public int? IdField { get; set; }
        public virtual Field Field { get; set; }


        //foreign key from another tables
        public virtual User User { get; set; }
        public virtual Challenge Challenge { get; set; }
    }
}