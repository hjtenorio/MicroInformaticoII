using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepTiporequerimiento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string CodParam { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaRegistra { get; set; }
        public int? UsuarioRegistra { get; set; }
        public DateTime? FechaModifica { get; set; }
        public int UsuarioModifica { get; set; }
        public int? OrdenRegistro { get; set; }
        public string Descrip { get; set; }
    }
}
