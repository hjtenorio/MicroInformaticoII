using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public class SpCabeceraTracking
    {
        public string Tin { get; set; }
        public string IdTipo { get; set; }
        public string Tipo { get; set; }
        public string Tarea { get; set; }
        public string Cola { get; set; }
        public string FlujoCola { get; set; }
        public string Temp1 { get; set; }
        public string Temp2 { get; set; }
        public string Diferencia { get; set; }
        public string Estado { get; set; }
    }
}
