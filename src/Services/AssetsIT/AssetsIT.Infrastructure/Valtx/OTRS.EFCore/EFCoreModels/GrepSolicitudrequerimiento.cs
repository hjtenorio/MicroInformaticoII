using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepSolicitudrequerimiento
    {
        public int IdSolicitudRequerimiento { get; set; }
        public int IdSolicitud { get; set; }
        public string IdTipoSolicitud { get; set; }
        public string IdTipoAccion { get; set; }
        public string IdTipoSoftware { get; set; }
        public string IdTipoComponente { get; set; }
        public string NroSerieRecurso { get; set; }
        public string IdTipoRecurso { get; set; }
        public string LicenciaSoftware { get; set; }
        public string NroInventarioRecurso { get; set; }
        public string NroSerieAsociado { get; set; }
        public string DireccionDestino { get; set; }
        public string NroSerieMonitor { get; set; }
        public string NroInventarioMonitor { get; set; }
        public string InventarioOrigen { get; set; }
        public string InventarioDestino { get; set; }
        public string CuentaRed { get; set; }
        public string OrdenCompra { get; set; }
        public string Ubicacion { get; set; }
        public string UbicacionOrigen { get; set; }
        public string UbicacionDestino { get; set; }
        public string Local { get; set; }
        public string Mouse { get; set; }
        public string Teclado { get; set; }
        public string FechaRegistra { get; set; }
        public string FechaActualiza { get; set; }
        public string UsuarioRegistra { get; set; }
        public string UsuarioModifica { get; set; }
        public string SerieEquipoOrigen { get; set; }
        public string SerieEquipoDestino { get; set; }
        public string Rpmcontacto { get; set; }
        public string TipoRequerimiento { get; set; }
    }
}
