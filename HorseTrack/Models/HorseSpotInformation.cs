using System;

namespace HorseTrack.Models
{
    public class HorseSpotInformation
    {
        public string Name { get; set; }
        public ChannelInformation[] Channels { get; set; }
        public DateTime RefTime { get; set; }
    }
}