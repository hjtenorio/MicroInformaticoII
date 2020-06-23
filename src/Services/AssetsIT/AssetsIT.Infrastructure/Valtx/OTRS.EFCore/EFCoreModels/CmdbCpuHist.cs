using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class CmdbCpuHist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DeploymentState { get; set; }
        public string IncidentState { get; set; }
        public string Serie { get; set; }
        public string TipoPropiedad { get; set; }
        public string Type { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public string Owner { get; set; }
        public string Zonal { get; set; }
        public string Local { get; set; }
        public string Ubicacion { get; set; }
        public string OrdenCompra { get; set; }
        public string Anexo { get; set; }
        public string EstadoAnexo { get; set; }
        public string ContratoMarco { get; set; }
        public string Solpe { get; set; }
        public DateTime? FechaCompra { get; set; }
        public DateTime? FechaRecepcion { get; set; }
        public string GarComercial { get; set; }
        public string GarSoporte { get; set; }
        public DateTime? FechaGarantia { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaDev { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Disco { get; set; }
        public string SistemaOper { get; set; }
        public string Lectora { get; set; }
        public string Disquetera { get; set; }
        public string LectoraGrab { get; set; }
        public string Note { get; set; }
        public DateTime? FechaMod { get; set; }
    }
}
