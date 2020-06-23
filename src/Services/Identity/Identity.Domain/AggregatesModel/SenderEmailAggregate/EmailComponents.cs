namespace Identity.Domain.AggregatesModel.SenderEmailAggregate
{
    public class EmailComponents
    {
        public string SenderEmail { get; set; }
        public string SenderEmailName { get; set; }
        public string ReceiverEmail { get; set; }
        public string ReceiverEmailName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Server Server { get; set; }
    }
}
