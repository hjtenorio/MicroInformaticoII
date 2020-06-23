namespace AssetsIT.API.Configuration
{
    public class TicketSettings
    {
        public string TicketDetailUrl { get; set; }
        public int StolenAlertServiceID { get; set; }
        public int AssetReturnTerminationServiceID { get; set; }
    }
    public class EmailSettings
    {
        public string EmailServerUrl { get; set; }
        public int EmailServerPort { get; set; }
        public string ReceiverEmailApi { get; set; }
        public string ReceiverEmailNameApi { get; set; }
    }
    public class OtrsConnectionStrings
    {
        public string WebBaseUrl { get; set; }
        public string UserLogin { get; set; }
        public string CustomerUserLogin { get; set; }
        public string Password { get; set; }
    }
}