using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepContrata
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string CuentaRed { get; set; }
        public DateTime? FechaRegistra { get; set; }
        public DateTime? FechaActualiza { get; set; }
        public string UsuarioRegistra { get; set; }
        public string UsuarioActualiza { get; set; }
    }
}
