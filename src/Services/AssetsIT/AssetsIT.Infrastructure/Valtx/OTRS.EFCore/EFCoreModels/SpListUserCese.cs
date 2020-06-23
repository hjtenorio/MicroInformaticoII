using System;

namespace AssetsIT.Infrastructure.Valtx.OTRS.EFCore.EFCoreModels
{
    public class SpListUserCese
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string CustomerId { get; set; }
        public string Dni { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime TerminationDate { get; set; }
        public DateTime? RenewalDate { get; set; }
    }
}
