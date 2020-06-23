namespace AssetsIT.BackgroundTasks.Configuration
{
    public class EmailSettings
    {
        public string EmailServerUrl { get; set; }
        public int EmailServerPort { get; set; }
        public string ReceiverEmailApi { get; set; }
        public string ReceiverEmailNameApi { get; set; }
    }

    public class UrlSpa
    {
        public string ListEmployeeTermination { get; set; }
    }
}