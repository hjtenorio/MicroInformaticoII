using AssetsIT.Domain.AggregatesModel.AssetsAggregate;

namespace AssetsIT.Domain.AggregatesModel.StolenAlertAggregate
{
    public class StolenAlert
    {
        public string UserCip { get; set; }
        public int OtrsServiceId { get; set; }
        public string Description { get; set; }
        public PoliceReport PoliceReport { get; set; }
        public Affidavit Affidavit { get; set; }
        public Asset Asset { get; set; }
    }
}