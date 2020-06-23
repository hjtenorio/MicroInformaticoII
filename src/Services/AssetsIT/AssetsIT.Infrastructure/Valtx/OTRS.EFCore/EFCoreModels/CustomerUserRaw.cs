using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class CustomerUserRaw
    {
        public string Cip { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string NombrePuesto { get; set; }
        public string FechaBaja { get; set; }
        public string Sigla { get; set; }
        public string NombreEmpresa { get; set; }
        public string NombreDireccion { get; set; }
        public string NombreGerencia { get; set; }
        public string NombreJefatura { get; set; }
        public string NombreSup { get; set; }
        public string NombreResponsableJefatura { get; set; }
        public string IdJefeInmediato { get; set; }
        public string NombresJefeInmediato { get; set; }
        public string ApePaternoJefeInmediato { get; set; }
        public string ApeMaternoJefeInmediato { get; set; }
        public string NombresSede { get; set; }
        public string DirperTelefDire { get; set; }
        public string DirperTelefRpm { get; set; }
        public string DirperTelefCel { get; set; }
        public string Correo { get; set; }
        public string DateIniLic { get; set; }
        public string DateFinLic { get; set; }
        public int? IdTipoLic { get; set; }
        public string Ceco { get; set; }
    }
}
