using System;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public class CmdbCpu
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DeploymentState { get; set; }
        public string IncidentState { get; set; }
        public string Comentario { get; set; }
        public string EstadoEquipo { get; set; }
        public string Serie { get; set; }
        public string TipoPropiedad { get; set; }
        public string Type { get; set; }
        public string Modelo { get; set; }
        public string Fabricante { get; set; }
        public string Owner { get; set; }
        public string NegPropietario { get; set; }
        public string DirPropietario { get; set; }
        public string GerPropietario { get; set; }
        public string JefPropietario { get; set; }
        public string NegPropNow { get; set; }
        public string DirPropNow { get; set; }
        public string GerPropNow { get; set; }
        public string JefPropNow { get; set; }
        public string Zonal { get; set; }
        public string Local { get; set; }
        public string Ubicacion { get; set; }
        public string OrdenCompra { get; set; }
        public string Anexo { get; set; }
        public string EstadoAnexo { get; set; }
        public string ContratoMarco { get; set; }
        public string Solpe { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public DateTime ActivationDate { get; set; }
        public string GarComercial { get; set; }
        public string GarSoporte { get; set; }
        public DateTime FechaGarantia { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaDev { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Disco { get; set; }
        public string SistemaOper { get; set; }
        public string Lectora { get; set; }
        public string Disquetera { get; set; }
        public string LectoraGrab { get; set; }
        public string LectExterno { get; set; }
        public string Teclado { get; set; }
        public string Mouse { get; set; }
        public string CableSeg { get; set; }
        public string Cargador { get; set; }
        public string Maletin { get; set; }
        public string TipoMon { get; set; }
        public string Precio { get; set; }
        public string Note { get; set; }
        public DateTime FechaMod { get; set; }
    }
}