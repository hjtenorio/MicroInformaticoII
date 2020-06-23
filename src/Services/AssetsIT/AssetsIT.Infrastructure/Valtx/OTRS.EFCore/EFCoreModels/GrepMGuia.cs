using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepMGuia
    {
        public int Id { get; set; }
        public string NroSerieGuia { get; set; }
        public string NroGuia { get; set; }
        public int? IdSolicitud { get; set; }
        public string Ticket { get; set; }
        public DateTime? FechaTraslado { get; set; }
        public string DniUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Destino { get; set; }
        public string Origen { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Ruc { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public string NroCertInsc { get; set; }
        public string AprobMtc { get; set; }
        public string Nrolicencia { get; set; }
        public int? VentaCompra { get; set; }
        public int? DemostracionAlquiler { get; set; }
        public int? ConsignacionPrestamo { get; set; }
        public int? Reparacion { get; set; }
        public int? Devolucion { get; set; }
        public int? TrasladoEstablecimientos { get; set; }
        public int? TrasladoEmisor { get; set; }
        public int? Otros { get; set; }
        public string Gerencia { get; set; }
        public string Jefatura { get; set; }
        public string Subgerencia { get; set; }
        public string Unidad { get; set; }
        public string UsuarioContacto { get; set; }
        public string TelefonoContacto { get; set; }
        public string Obs { get; set; }
        public string Despachado { get; set; }
        public string Autorizado { get; set; }
        public string UsuarioRegistra { get; set; }
        public int? Usrcre { get; set; }
        public DateTime? Fchcre { get; set; }
        public string UsuarioActualiza { get; set; }
        public int? Usract { get; set; }
        public DateTime? Fchact { get; set; }
        public string RucTrans { get; set; }
        public string Estado { get; set; }
        public string EstadoProceso { get; set; }
    }
}
