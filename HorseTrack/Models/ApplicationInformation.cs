using Newtonsoft.Json;
using System.Collections.Generic;

namespace HorseTrack.Models
{
    internal class ApplicationInformation
    {
        [JsonIgnore]
        public bool FromFile { get; set; }

        [JsonProperty("spots")]
        public List<HorseSpotInformation> SpotsInformation { get; set; }

        [JsonProperty("cnt")]
        public string HorseCount { get; set; }

        public ApplicationInformation()
        {
            SpotsInformation = new List<HorseSpotInformation>();
        }
    }
}