using System;
using System.Collections.Generic;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public class SpDetalleAdjuntosTracking
    {
        public int ArticuloId { get; set; }
        public string ContentType { get; set; }
        public string NombreArchivo { get; set; }
        public byte[] Content { get; set; }
    }
}
