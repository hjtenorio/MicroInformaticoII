using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class SmServicios
    {
        public string Id { get; set; }
        public string IdCliser { get; set; }
        public string Cliente { get; set; }
        public string Nombre { get; set; }
        public string Ocompra { get; set; }
        public int? Horasm { get; set; }
        public int? Horasa { get; set; }
        public decimal? RemoOfic { get; set; }
        public decimal? RemoExtra { get; set; }
        public decimal? PreOfic { get; set; }
        public decimal? PreExtra { get; set; }
    }
}
