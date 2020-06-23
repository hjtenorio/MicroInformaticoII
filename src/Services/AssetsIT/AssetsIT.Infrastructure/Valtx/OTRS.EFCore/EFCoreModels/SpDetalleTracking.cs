using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public class SpDetalleTracking
    {
        public int QueueId { get; set; }
        public int ArticuloId { get; set; }
        public string ABody { get; set; }        
        public DateTime? CreatedTime { get; set; }
        public string CreadoPor { get; set; }
        public string Especialista { get; set; }
        public int TipoHistoria { get; set; }
    }
}
