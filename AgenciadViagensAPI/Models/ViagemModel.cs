using AgenciadViagensAPI.Enums;
using System.Data;

namespace AgenciadViagensAPI.Models
{
    public class ViagemModel
    {
        public int Id { get; set; }
        public string? origem { get; set; }
        public string? destino { get; set; }
        public StatusViagem Status { get; set; }
     

    
    }
}
