using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class OtrsTk
    {
        public string TituloTk { get; set; }
        public int Timeout { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ChangeTime { get; set; }
        public string EstadoTicket { get; set; }
        public string ColaEquipo { get; set; }
        public string ComentarioCola { get; set; }
        public string PuestoDeTrabajo { get; set; }
        public string Criticidad { get; set; }
        public string Usuario { get; set; }
    }
}
