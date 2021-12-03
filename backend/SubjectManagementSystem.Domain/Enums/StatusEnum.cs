using System.ComponentModel;

namespace SubjectManagementSystem.Domain
{
    public enum StatusEnum
    {
        [Description("Não Iniciado")]
        NotStarted,
        [Description("Em Progresso")]
        OnProgress,
        [Description("Em Pausa")]
        OnPause,
        [Description("Cancelado")]
        Canceled,
        [Description("Finalizado")]
        Finished
    }
}