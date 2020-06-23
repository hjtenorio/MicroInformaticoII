using System;

namespace AssetsIT.Domain.AggregatesModel.CustomerUserAggregate
{
    public class CustomerUserData
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string CustomerId { get; set; }
        public string Dni { get; set; }
        public string Charge { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public DateTime TerminationDate { get; set; }
        public DateTime? RenewalDate { get; set; }
        public bool RenewalStatus { get; set; }
    }
}