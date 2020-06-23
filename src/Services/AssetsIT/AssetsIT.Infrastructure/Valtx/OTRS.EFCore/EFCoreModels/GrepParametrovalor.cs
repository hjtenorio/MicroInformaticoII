using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepParametrovalor
    {
        public string IdParametroValor { get; set; }
        public string IdParametro { get; set; }
        public string Abreviatura { get; set; }
        public string IdParametroValorPadre { get; set; }
        public string Descripcion { get; set; }
        public string Valor { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaRegistra { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string UsuarioRegistra { get; set; }
        public string UsuarioModifica { get; set; }
    }
}
