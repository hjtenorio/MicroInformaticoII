using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepTipreqCombina
    {
        public int Id { get; set; }
        public string Tipreq { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaRegistra { get; set; }
        public int? UsuarioRegistra { get; set; }
        public DateTime? FechaModifica { get; set; }
        public int? UsuarioModifica { get; set; }
    }
}
