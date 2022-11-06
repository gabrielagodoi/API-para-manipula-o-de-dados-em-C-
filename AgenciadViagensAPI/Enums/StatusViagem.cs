using System.ComponentModel;

namespace AgenciadViagensAPI.Enums
{
    public enum StatusViagem
    {
        [Description("Em Andamento")]
        EmAndamento = 1,
        [Description("Concluído")]
        Concluído = 2,

    }
}
