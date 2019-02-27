using System.Xml.Serialization;

namespace HattrickApiModel
{
    [XmlRoot(ElementName = "TransferDetails")]
    public class TransferDetails
    {
        [XmlElement(ElementName = "AskingPrice")]
        public string AskingPrice { get; set; }
        [XmlElement(ElementName = "Deadline")]
        public string Deadline { get; set; }
        [XmlElement(ElementName = "HighestBid")]
        public string HighestBid { get; set; }
        [XmlElement(ElementName = "BidderTeam")]
        public string BidderTeam { get; set; }
    }
}