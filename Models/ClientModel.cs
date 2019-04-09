using System;

namespace TMARC_WebAPI.Models
{
    public class ClientModel : Clients
    {
        public int KeywordID { get; set; }
        public string Keyword { get; set; }
    }


    public class ObjIpLookup
    {
        public DateTime CaptureTime { get; set; }
        public string @as { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string isp { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public string org { get; set; }
        public string query { get; set; }
        public string region { get; set; }
        public string regionName { get; set; }
        public string status { get; set; }
        public string timezone { get; set; }
        public string zip { get; set; }
    }


    public class Clients : ObjIpLookup
    {
        public int ClientID { get; set; }
        public bool ClientOptIn { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientProfile { get; set; }
        public string ClientRewards { get; set; }
    }
}