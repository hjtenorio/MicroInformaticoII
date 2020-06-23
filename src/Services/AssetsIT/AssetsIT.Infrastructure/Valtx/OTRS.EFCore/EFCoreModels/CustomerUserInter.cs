using System;
using System.Collections.Generic;

namespace Valtx
{
    public partial class CustomerUserInter
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string CustomerId { get; set; }
        public string Pw { get; set; }
        public string Dni { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Directo { get; set; }
        public string Rpm { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Departamento { get; set; }
        public string Country { get; set; }
        public string Cargo { get; set; }
        public string Sigla { get; set; }
        public string Empresa { get; set; }
        public string Direccion { get; set; }
        public string Gerencia { get; set; }
        public string Jefatura { get; set; }
        public string Supervision { get; set; }
        public string Jefe { get; set; }
        public string CipJefeInmediato { get; set; }
        public string JefeInmediato { get; set; }
        public string Comments { get; set; }
        public short ValidId { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime ChangeTime { get; set; }
        public int ChangeBy { get; set; }
        public string DateIniLic { get; set; }
        public string DateFinLic { get; set; }
        public int IdTipoLic { get; set; }
        public string Ceco { get; set; }
    }
}
