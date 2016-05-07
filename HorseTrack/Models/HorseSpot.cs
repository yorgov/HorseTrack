using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HorseTrack.Models
{
    class HorseSpotInformation
    {
        public string Name { get; set; }
        
        public int[] Times { get; set; }

        public DateTime RefTime { get; set; }
        public HorseSpotInformation()
        {
            Times = new int[12];
        }
    }
}
