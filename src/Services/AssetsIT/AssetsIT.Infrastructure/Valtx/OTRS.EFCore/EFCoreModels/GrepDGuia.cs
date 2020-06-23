using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepDGuia
    {
        public int Id { get; set; }
        public int Item { get; set; }
        public string Descripcion { get; set; }
        public decimal? Peso { get; set; }
        public int? Cantidad { get; set; }
        public string Documento { get; set; }
        public string Inventario { get; set; }
        public string Serie { get; set; }
        public string Estado { get; set; }
        public string UsuarioRegistra { get; set; }
        public int? Usrcre { get; set; }
        public DateTime? Fchcre { get; set; }
        public string UsuarioActualiza { get; set; }
        public int? Usract { get; set; }
        public DateTime? Fchact { get; set; }
    }
}
