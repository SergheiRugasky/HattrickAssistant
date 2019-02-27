using System.Xml.Serialization;

namespace HattrickApiModel
{
    [XmlRoot(ElementName = "OwningTeam")]
    public class OwningTeam
    {
        [XmlElement(ElementName = "TeamID")]
        public string TeamID { get; set; }
        [XmlElement(ElementName = "TeamName")]
        public string TeamName { get; set; }
        [XmlElement(ElementName = "LeagueID")]
        public string LeagueID { get; set; }
    }
}