namespace Identity.API.Configuration
{
    public class AppSettings
    {
        public string Secret { get; set; }
    }

    public class ResetPasswordSettings
    {
        public string WebBaseUrl { get; set; }
    }

    public class EmailSettings
    {
        public string EmailServerUrl { get; set; }
        public int EmailServerPort { get; set; }
        public string ReceiverEmailApi { get; set; }
        public string ReceiverEmailNameApi { get; set; }
    }
}