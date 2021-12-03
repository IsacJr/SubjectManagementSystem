using System.ComponentModel;

namespace SubjectManagementSystem.Domain
{
    public enum UserTypeEnum
    {
        [Description("Professor")]
        Professor,
        [Description("Parceiro")]
        BusinessPartner,
        [Description("Estudante")]
        Student,
        [Description("Admin")]
        Admin
    }
}