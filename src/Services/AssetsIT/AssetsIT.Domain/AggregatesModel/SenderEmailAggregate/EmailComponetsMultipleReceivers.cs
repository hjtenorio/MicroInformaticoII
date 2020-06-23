using System.Collections.Generic;

namespace AssetsIT.Domain.AggregatesModel.SenderEmailAggregate
{
    public class EmailComponetsMultipleReceivers
    {
        public string SenderEmail { get; set; }
        public string SenderEmailName { get; set; }
        public List<string> ReceiverEmail { get; set; }
        public string ReceiverEmailName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public Server Server { get; set; }
    }
}
