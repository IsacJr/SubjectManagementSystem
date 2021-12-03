using System.ComponentModel;

namespace SubjectManagementSystem.Domain
{
    public enum EducationLevelEnum
    {
        [Description("Graduação")]
        Graduate,
        [Description("Pós-Graduação")]
        Postgraduate,
        [Description("Mestrado")]
        Master,
        [Description("Doutorado")]
        Doctorate
    }
}