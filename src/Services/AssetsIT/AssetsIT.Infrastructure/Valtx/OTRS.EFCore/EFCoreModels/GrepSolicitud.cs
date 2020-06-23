using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepSolicitud
    {
        public int IdSolicitud { get; set; }
        public string CodigoSolicitud { get; set; }
        public string IdTipoSolicitud { get; set; }
        public int? IdTipSol { get; set; }
        public string CipSolicitante { get; set; }
        public string CipUsuario { get; set; }
        public string CipAutorizador { get; set; }
        public string DniUsuario { get; set; }
        public string DniSolicitante { get; set; }
        public string DniAutorizador { get; set; }
        public string EmailAutorizador { get; set; }
        public int? TipoAccion { get; set; }
        public string IdTipoAccion { get; set; }
        public string DireccionFisica { get; set; }
        public string Ticket { get; set; }
        public string EstadoProceso { get; set; }
        public string Estado { get; set; }
        public string Comentario { get; set; }
        public string IdTipo2Equipo { get; set; }
        public string IdTipo2Componente { get; set; }
        public int? EnvioCorreoExterno { get; set; }
        public int? EnvioCorreoWeb { get; set; }
        public string FlagPreEquipos { get; set; }
        public string FlagInstSoftware { get; set; }
        public string FlagInstComponentes { get; set; }
        public int? FlagTrasladoEquipo { get; set; }
        public DateTime FechaRegistra { get; set; }
        public DateTime? FechaActualiza { get; set; }
        public string UsuarioRegistra { get; set; }
        public string UsuarioActualiza { get; set; }
        public int? Usrcre { get; set; }
        public int? Usract { get; set; }
        public string SerieEquipoOrigen { get; set; }
        public string SerieEquipoDestino { get; set; }
        public string Rpmcontacto { get; set; }
        public string CuentaRedUsuario { get; set; }
        public string DniContrata { get; set; }
        public short? PisoUsuario { get; set; }
        public string Rpmsolicitante { get; set; }
        public string Rpmusuario { get; set; }
        public string ArchivoAcuerdoConfidencialidad { get; set; }
        public int? EnvioCorreoSmart { get; set; }
        public string IdModoLicenciamiento { get; set; }
        public string FlagTrasladoInf { get; set; }
        public string Contacto { get; set; }
        public string DestinoLocal { get; set; }
        public string OrigenLocal { get; set; }
        public string DestinoDireccion { get; set; }
        public string OrigenDireccion { get; set; }
        public string DestinoPiso { get; set; }
        public string OrigenPiso { get; set; }
        public string TelefonoContacto { get; set; }
        public string UsuarioOrigen { get; set; }
        public string Contrata { get; set; }
        public int? FlagGuia { get; set; }
        public string NroSerieGuia { get; set; }
        public string NroGuia { get; set; }
        public string InventarioAntiguo { get; set; }
        public string UsuarioAntiguo { get; set; }
    }
}
