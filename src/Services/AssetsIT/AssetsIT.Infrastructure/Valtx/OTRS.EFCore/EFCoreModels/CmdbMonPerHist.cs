using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class CmdbMonPerHist
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DepState { get; set; }
        public string IncState { get; set; }
        public string Serie { get; set; }
        public string Model { get; set; }
        public string Detalle { get; set; }
        public string Fabric { get; set; }
        public string Owner { get; set; }
        public string Zonal { get; set; }
        public string Local { get; set; }
        public string Ubica { get; set; }
        public string OrdenCo { get; set; }
        public string Anexo { get; set; }
        public string EstAnexo { get; set; }
        public string ContMarco { get; set; }
        public string Solpe { get; set; }
        public DateTime? FechaComp { get; set; }
        public DateTime? FechaRep { get; set; }
        public string GarCom { get; set; }
        public string GarSop { get; set; }
        public DateTime? FechaGar { get; set; }
        public string Proved { get; set; }
        public DateTime? FechaDev { get; set; }
        public string Note { get; set; }
        public DateTime? FechaModH { get; set; }
    }
}
