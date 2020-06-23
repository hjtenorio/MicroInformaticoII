using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepTiporequerimientoSubtipos
    {
        public int Id { get; set; }
        public int Idtipreq { get; set; }
        public string Titulo { get; set; }
        public string CodParam { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaRegistra { get; set; }
        public int? UsuarioRegistra { get; set; }
        public DateTime? FechaModifica { get; set; }
        public int? UsuarioModifica { get; set; }
    }
}
