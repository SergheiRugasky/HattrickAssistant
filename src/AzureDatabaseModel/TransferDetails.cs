using System.Xml.Serialization;

namespace AzureDatabaseModel
{
    public class TransferDetails
    {
        public string AskingPrice { get; set; }
        public string Deadline { get; set; }
        public string HighestBid { get; set; }
        public string BidderTeam { get; set; }
    }
}