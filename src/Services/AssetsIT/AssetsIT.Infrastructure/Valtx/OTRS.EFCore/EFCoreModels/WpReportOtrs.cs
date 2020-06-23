using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class WpReportOtrs
    {
        public string Id { get; set; }
        public string Inventario { get; set; }
        public string Serie { get; set; }
        public string EstadoDeDespliegue { get; set; }
        public string TipoDePropiedad { get; set; }
        public string Anexo { get; set; }
        public DateTime FechaDeDevolución { get; set; }
        public string Cip { get; set; }
        public string NombreCompleto { get; set; }
        public string Negocio { get; set; }
        public string Gerencia { get; set; }
        public string SubGerencia { get; set; }
        public string Jefatura { get; set; }
        public string EstadoDelUsuario { get; set; }
    }
}
