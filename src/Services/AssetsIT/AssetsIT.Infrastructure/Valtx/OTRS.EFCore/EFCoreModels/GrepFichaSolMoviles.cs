using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepFichaSolMoviles
    {
        public int IdSolMov { get; set; }
        public string CodSolMov { get; set; }
        public string CipSolicitante { get; set; }
        public string CipMando { get; set; }
        public string CipColaborador { get; set; }
        public string NroCelular { get; set; }
        public DateTime FechaAlta { get; set; }
        public string LocalidadEntrega { get; set; }
        public string ModalidadEntrega { get; set; }
        public string TipoEquipo { get; set; }
        public string SimCard { get; set; }
        public string MotivoSolicitud { get; set; }
        public string FormaPago { get; set; }
        public string DevuelveEquipoAnt { get; set; }
        public string ModeloEquipoDev { get; set; }
        public string DatoAdicional { get; set; }
        public string Plan { get; set; }
        public string DetallePlan { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
