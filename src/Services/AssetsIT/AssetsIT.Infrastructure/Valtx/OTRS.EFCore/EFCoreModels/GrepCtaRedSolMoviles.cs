using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepCtaRedSolMoviles
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CuentaRed { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string Estado { get; set; }
    }
}
