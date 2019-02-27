using System.Xml.Serialization;

namespace HattrickApiModel
{
    [XmlRoot(ElementName = "PlayerSkills")]
    public class PlayerSkills
    {
        [XmlElement(ElementName = "StaminaSkill")]
        public string StaminaSkill { get; set; }
        [XmlElement(ElementName = "KeeperSkill")]
        public string KeeperSkill { get; set; }
        [XmlElement(ElementName = "PlaymakerSkill")]
        public string PlaymakerSkill { get; set; }
        [XmlElement(ElementName = "ScorerSkill")]
        public string ScorerSkill { get; set; }
        [XmlElement(ElementName = "PassingSkill")]
        public string PassingSkill { get; set; }
        [XmlElement(ElementName = "WingerSkill")]
        public string WingerSkill { get; set; }
        [XmlElement(ElementName = "DefenderSkill")]
        public string DefenderSkill { get; set; }
        [XmlElement(ElementName = "SetPiecesSkill")]
        public string SetPiecesSkill { get; set; }
    }
}