using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace OnlineTools.Models
{
    public class IPGeographicalLocation
    {
        [JsonProperty("as")]
        public string As { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string Counry_Code { get; set; }

        [JsonProperty("country")]
        public string CountryName { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("regionName")]
        public string RegionName { get; set; }

        [JsonProperty("query")]
        public string IP { get; set; }
   
        [JsonProperty("org")]
        public string Org { get; set; }

        [JsonProperty("isp")]
        public string Isp { get; set; }

        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("lon")]
        public float Longitude { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("success")]
        public string Success { get; set; }

        private IPGeographicalLocation() { }

        public static async Task<IPGeographicalLocation> QueryGeographicalLocationAsync(string ipAddress)
        {
            HttpClient client = new HttpClient();
            string result = await client.GetStringAsync("http://ip-api.com/json/" + ipAddress);

            return JsonConvert.DeserializeObject<IPGeographicalLocation>(result);
        }
}
}