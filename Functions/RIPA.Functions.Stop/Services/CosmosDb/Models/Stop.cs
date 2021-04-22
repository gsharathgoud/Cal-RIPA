﻿namespace RIPA.Functions.Stop.Services.CosmosDb.Models
{
    public class Stop
    {
        public string ori { get; set; }
        public string Agency { get; set; }
        public string OfficerID { get; set; }
        public string ExpYears { get; set; }
        public OfficerAssignment OfficerAssignment { get; set; }
        public bool ContractFundedPosition { get; set; }
        public ContractCity ContractCity { get; set; }
        public bool ContractFundedEvent { get; set; }
        public string ContractEvent { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Location Location { get; set; }
        public int StopDuration { get; set; }
        public bool StopInResponseToCFS { get; set; }
        public PeopleStopped[] PeopleStopped { get; set; }
    }

    public class OfficerAssignment
    {
        public string Key { get; set; }
        public string Type { get; set; }
        public string OtherType { get; set; }
    }

    public class ContractCity
    {
        public object[] Codes { get; set; }
    }

    public class Location
    {
        public bool ToggleLocationOptions { get; set; }
        public string Intersection { get; set; }
        public int BlockNumber { get; set; }
        public string LandMark { get; set; }
        public string StreetName { get; set; }
        public string HighwayExit { get; set; }
        public City City { get; set; }
        public Beat Beat { get; set; }
        public bool School { get; set; }
        public SchoolName SchoolName { get; set; }
        public bool OutOfCounty { get; set; }
    }

    public class City
    {
        public Codes[] Codes { get; set; }
    }

    public class Codes
    {
        public string Code { get; set; }
        public string Text { get; set; }
    }

    public class Beat
    {
        public object[] Codes { get; set; }
    }

    public class SchoolName
    {
        public object[] Codes { get; set; }
    }

    public class PeopleStopped
    {
        public string Id { get; set; }
        public bool IsStudent { get; set; }
        public PerceivedRace[] PerceivedRace { get; set; }
        public bool PerceivedLimitedEnglish { get; set; }
        public PerceivedOrKnownDisability[] PerceivedOrKnownDisability { get; set; }
        public int PerceivedAge { get; set; }
        public string PerceivedGender { get; set; }
        public bool GenderNonconforming { get; set; }
        public int Gender { get; set; }
        public string PerceivedLgbt { get; set; }
        public ReasonForStop ReasonForStop { get; set; }
        public string PerceptionKnown { get; set; }
        public string ReasonForStopExplanation { get; set; }
        public ActionsTakenDuringStop[] ActionsTakenDuringStop { get; set; }
        public ContrabandOrEvidenceDiscovered[] ContrabandOrEvidenceDiscovered { get; set; }
        public object[] BasisForSearch { get; set; }
        public string BasisForSearchBrief { get; set; }
        public object[] BasisForPropertySeizure { get; set; }
        public object[] TypeOfPropertySeized { get; set; }
        public ResultOfStop[] ResultOfStop { get; set; }
    }

    public class ReasonForStop
    {
        public int Key { get; set; }
        public string Reason { get; set; }
        public Detail[] Details { get; set; }
        public Codes[] Codes { get; set; }
    }

    public class Detail
    {
        public string Reason { get; set; }
        public int Key { get; set; }
    }

    public class PerceivedRace
    {
        public string Race { get; set; }
        public int Key { get; set; }
    }

    public class PerceivedOrKnownDisability
    {
        public string Disability { get; set; }
        public int Key { get; set; }
    }

    public class ActionsTakenDuringStop
    {
        public string Action { get; set; }
        public string Key { get; set; }
    }

    public class ContrabandOrEvidenceDiscovered
    {
        public string Contraband { get; set; }
        public int Key { get; set; }
    }

    public class ResultOfStop
    {
        public string Result { get; set; }
        public Codes[] Codes { get; set; }
        public int Key { get; set; }
    }


}
