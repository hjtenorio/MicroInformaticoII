using System;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public class SpListTicketsByUser
    {
        public int Id { get; set; }
        public string Tn { get; set; }
        public int IdTipoSolicitud { get; set; }
        public string TipoSolicitud { get; set; }
        public string Solicitud { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public int IdEstado { get; set; }
        public string Estado { get; set; }
    }
}
