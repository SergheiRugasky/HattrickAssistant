using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace HattrickApiModel
{
    [XmlRoot(ElementName = "HattrickData")]
    public class HattrickData
    {
        [XmlElement(ElementName = "FileName")]
        public string FileName { get; set; }
        [XmlElement(ElementName = "Version")]
        public string Version { get; set; }
        [XmlElement(ElementName = "UserID")]
        public string UserID { get; set; }
        [XmlElement(ElementName = "FetchedDate")]
        public string FetchedDate { get; set; }
        [XmlElement(ElementName = "UserSupporterTier")]
        public string UserSupporterTier { get; set; }
        [XmlElement(ElementName = "IsPlayingMatch")]
        public string IsPlayingMatch { get; set; }
        [XmlElement(ElementName = "Player")]
        public Player Player { get; set; }
    }

}
