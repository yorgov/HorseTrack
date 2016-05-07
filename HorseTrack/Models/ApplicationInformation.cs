using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HorseTrack.Models
{
    class ApplicationInformation
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
