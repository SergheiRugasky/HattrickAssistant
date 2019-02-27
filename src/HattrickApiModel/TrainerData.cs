using System.Xml.Serialization;

namespace HattrickApiModel
{
    [XmlRoot(ElementName = "TrainerData")]
    public class TrainerData
    {
        [XmlElement(ElementName = "TrainerType")]
        public string TrainerType { get; set; }
        [XmlElement(ElementName = "TrainerSkill")]
        public string TrainerSkill { get; set; }
    }
}