using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepParametro
    {
        public string IdParametro { get; set; }
        public string Descripcion { get; set; }
        public string PermiteMostrar { get; set; }
        public string PermiteAgregar { get; set; }
        public string PermiteModificar { get; set; }
        public string PermiteEliminar { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaRegistra { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioRegistra { get; set; }
        public string UsuarioModifica { get; set; }
    }
}
