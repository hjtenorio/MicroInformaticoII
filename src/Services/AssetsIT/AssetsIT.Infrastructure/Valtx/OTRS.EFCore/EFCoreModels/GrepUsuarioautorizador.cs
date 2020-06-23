using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class GrepUsuarioautorizador
    {
        public int Id { get; set; }
        public string Empresa { get; set; }
        public string DireccionGerenciaJefatura { get; set; }
        public string NombresApellidos { get; set; }
        public string Correo { get; set; }
        public string Estado { get; set; }
        public string UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
        public string Cip { get; set; }
        public string Dni { get; set; }
        public string Direccion { get; set; }
        public string Gerencia { get; set; }
        public string Jefatura { get; set; }
        public int? Tipo { get; set; }
    }
}
