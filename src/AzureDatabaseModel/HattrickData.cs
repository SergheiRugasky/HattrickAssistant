using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AzureDatabaseModel
{
    public class HattrickData
    {
        public string UserID { get; set; }
        public string FetchedDate { get; set; }
        public Team Team { get; set; }
    }

    public class Team
    {
        public string TeamID { get; set; }
        public List<Player> Players { get; set; }
    }

    public class Player
    {
        public string PlayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Agreeability { get; set; }
        public string Aggressiveness { get; set; }
        public string Honesty { get; set; }
        public string Leadership { get; set; }
        public string Specialty { get; set; }
        public string NativeCountryID { get; set; }
        public TrainerData TrainerData { get; set; }
        public List<PlayerDetails> PlayerDetails { get; set; }
    }

    public class PlayerDetails
    {
        public int Age { get; set; }
        public int AgeDays { get; set; }
        public DateTime NextBirthDay { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int PlayerForm { get; set; }
        public int Cards { get; set; }
        public int InjuryLevel { get; set; }
        public string OwningTeamId { get; set; }
        public int Salary { get; set; }
        public bool IsAbroad { get; set; }
        public string Experience { get; set; }
        public string Loyalty { get; set; }
        public bool MotherClubBonus { get; set; }
        public string TSI { get; set; }
        public PlayerSkills PlayerSkills { get; set; }
        public string Caps { get; set; }
        public string CapsU20 { get; set; }
        public bool TransferListed { get; set; }
        public TransferDetails TransferDetails { get; set; }
    }
}
