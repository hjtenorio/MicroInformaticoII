using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class WpLicencias
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string NegProp { get; set; }
        public string DeploymentState { get; set; }
        public string TipoSw { get; set; }
        public string SwGenerico { get; set; }
        public string Version { get; set; }
        public double? CantidadTotal { get; set; }
        public long? CantidadUso { get; set; }
        public double? CantidadLibre { get; set; }
    }
}
