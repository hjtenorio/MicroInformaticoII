using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class CmdbLicencia
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string DeploymentState { get; set; }
        public string IncidentState { get; set; }
        public string TipoSw { get; set; }
        public string Grupo { get; set; }
        public string SwGenerico { get; set; }
        public string Version { get; set; }
        public string Cantidad { get; set; }
        public string Ordecompra { get; set; }
        public DateTime? FechaRece { get; set; }
        public DateTime? FechaComp { get; set; }
        public string Proveedor { get; set; }
        public string TipoMone { get; set; }
        public string PreUni { get; set; }
        public string NegProp { get; set; }
        public string DirProp { get; set; }
        public string GerProp { get; set; }
        public string JefProp { get; set; }
        public string Mante { get; set; }
        public DateTime? FechaIniMant { get; set; }
        public DateTime? FechaFinMant { get; set; }
        public string CodAct { get; set; }
        public string PlatSo { get; set; }
        public string Fabric { get; set; }
        public string Valid { get; set; }
        public string TipoLic { get; set; }
        public string EquipoLic { get; set; }
        public string Note { get; set; }
        public int? Estado { get; set; }
    }
}
