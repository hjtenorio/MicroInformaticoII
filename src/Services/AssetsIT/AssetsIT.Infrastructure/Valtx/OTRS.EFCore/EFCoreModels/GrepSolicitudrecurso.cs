using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepSolicitudrecurso
    {
        public int IdSolicitudRecurso { get; set; }
        public int IdSolicitud { get; set; }
        public int IdTipSol { get; set; }
        public int TipoAccion { get; set; }
        public string IdTipoSolicitud { get; set; }
        public string IdTipoAccion { get; set; }
        public string IdTipoRecurso { get; set; }
        public string NroSerieRecurso { get; set; }
        public string NroInventarioRecurso { get; set; }
        public string NroSerieRecursoOrigen { get; set; }
        public string NroSerieRecursoDestino { get; set; }
        public string NroSerieMonitor { get; set; }
        public string CuentaRed { get; set; }
        public string OrdenCompraOffice { get; set; }
        public string LocalOrigen { get; set; }
        public string LocalDestino { get; set; }
        public string UbicacionEquipo { get; set; }
        public string UbicacionOrigen { get; set; }
        public string UbicacionDestino { get; set; }
        public string EstadoRecurso { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string PisoOrigen { get; set; }
        public string PisoDestino { get; set; }
        public string PersonaContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public string Mouse { get; set; }
        public string Teclado { get; set; }
        public DateTime FechaRegistra { get; set; }
        public DateTime? FechaActualiza { get; set; }
        public string UsuarioRegistra { get; set; }
        public string UsuarioActualiza { get; set; }
        public string NombreEstacion { get; set; }
        public string Dominio { get; set; }
        public string Ip { get; set; }
        public string MacAddress { get; set; }
        public string TipoEqRenovacionTecno { get; set; }
        public string Licencia { get; set; }
        public string OrdenCompra { get; set; }
        public string IdTipoSoftware { get; set; }
        public string VersionSoftware { get; set; }
        public int? FlagPropiedad { get; set; }
        public string NroInventPropio { get; set; }
        public string Cpu { get; set; }
        public string Velocidadcpu { get; set; }
        public string Ram { get; set; }
        public string Disco { get; set; }
        public int? Usrcre { get; set; }
        public int? Usract { get; set; }
        public string Estado { get; set; }
    }
}
