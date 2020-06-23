using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SmPreoperaciones
    {
        public string Tn { get; set; }
        public string Title { get; set; }
        public DateTime? InicioAtencion { get; set; }
        public int? DiaSemana { get; set; }
        public string Torre { get; set; }
        public string Login { get; set; }
        public string Nombre { get; set; }
        public string CustomerId { get; set; }
        public string Empresa { get; set; }
        public string CliExt { get; set; }
        public string TipoSoporte { get; set; }
        public long? Minutos { get; set; }
        public DateTime? FinAtencion { get; set; }
        public string Horas { get; set; }
        public string FlgNohorario { get; set; }
        public string FlgNolaborable { get; set; }
        public string Codmes { get; set; }
    }
}
