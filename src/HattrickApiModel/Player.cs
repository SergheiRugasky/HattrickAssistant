using System.Xml.Serialization;

namespace HattrickApiModel
{
    [XmlRoot(ElementName = "Player")]
    public class Player
    {
        [XmlElement(ElementName = "PlayerID")]
        public string PlayerID { get; set; }
        [XmlElement(ElementName = "FirstName")]
        public string FirstName { get; set; }
        [XmlElement(ElementName = "NickName")]
        public string NickName { get; set; }
        [XmlElement(ElementName = "LastName")]
        public string LastName { get; set; }
        [XmlElement(ElementName = "PlayerNumber")]
        public string PlayerNumber { get; set; }
        [XmlElement(ElementName = "PlayerCategoryID")]
        public string PlayerCategoryID { get; set; }
        [XmlElement(ElementName = "OwnerNotes")]
        public string OwnerNotes { get; set; }
        [XmlElement(ElementName = "Age")]
        public string Age { get; set; }
        [XmlElement(ElementName = "AgeDays")]
        public string AgeDays { get; set; }
        [XmlElement(ElementName = "NextBirthDay")]
        public string NextBirthDay { get; set; }
        [XmlElement(ElementName = "ArrivalDate")]
        public string ArrivalDate { get; set; }
        [XmlElement(ElementName = "PlayerForm")]
        public string PlayerForm { get; set; }
        [XmlElement(ElementName = "Cards")]
        public string Cards { get; set; }
        [XmlElement(ElementName = "InjuryLevel")]
        public string InjuryLevel { get; set; }
        [XmlElement(ElementName = "Statement")]
        public string Statement { get; set; }
        [XmlElement(ElementName = "PlayerLanguage")]
        public string PlayerLanguage { get; set; }
        [XmlElement(ElementName = "PlayerLanguageID")]
        public string PlayerLanguageID { get; set; }
        [XmlElement(ElementName = "TrainerData")]
        public TrainerData TrainerData { get; set; }
        [XmlElement(ElementName = "OwningTeam")]
        public OwningTeam OwningTeam { get; set; }
        [XmlElement(ElementName = "Salary")]
        public string Salary { get; set; }
        [XmlElement(ElementName = "IsAbroad")]
        public string IsAbroad { get; set; }
        [XmlElement(ElementName = "Agreeability")]
        public string Agreeability { get; set; }
        [XmlElement(ElementName = "Aggressiveness")]
        public string Aggressiveness { get; set; }
        [XmlElement(ElementName = "Honesty")]
        public string Honesty { get; set; }
        [XmlElement(ElementName = "Experience")]
        public string Experience { get; set; }
        [XmlElement(ElementName = "Loyalty")]
        public string Loyalty { get; set; }
        [XmlElement(ElementName = "MotherClubBonus")]
        public string MotherClubBonus { get; set; }
        [XmlElement(ElementName = "Leadership")]
        public string Leadership { get; set; }
        [XmlElement(ElementName = "Specialty")]
        public string Specialty { get; set; }
        [XmlElement(ElementName = "NativeCountryID")]
        public string NativeCountryID { get; set; }
        [XmlElement(ElementName = "NativeLeagueID")]
        public string NativeLeagueID { get; set; }
        [XmlElement(ElementName = "NativeLeagueName")]
        public string NativeLeagueName { get; set; }
        [XmlElement(ElementName = "TSI")]
        public string TSI { get; set; }
        [XmlElement(ElementName = "PlayerSkills")]
        public PlayerSkills PlayerSkills { get; set; }
        [XmlElement(ElementName = "Caps")]
        public string Caps { get; set; }
        [XmlElement(ElementName = "CapsU20")]
        public string CapsU20 { get; set; }
        [XmlElement(ElementName = "CareerGoals")]
        public string CareerGoals { get; set; }
        [XmlElement(ElementName = "CareerHattricks")]
        public string CareerHattricks { get; set; }
        [XmlElement(ElementName = "LeagueGoals")]
        public string LeagueGoals { get; set; }
        [XmlElement(ElementName = "CupGoals")]
        public string CupGoals { get; set; }
        [XmlElement(ElementName = "FriendliesGoals")]
        public string FriendliesGoals { get; set; }
        [XmlElement(ElementName = "GoalsCurrentTeam")]
        public string GoalsCurrentTeam { get; set; }
        [XmlElement(ElementName = "TransferListed")]
        public string TransferListed { get; set; }
        [XmlElement(ElementName = "TransferDetails")]
        public TransferDetails TransferDetails { get; set; }
    }
}