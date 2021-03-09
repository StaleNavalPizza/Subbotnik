using System;
using System.Collections.Generic;

namespace Subbotnik.Model
{
    public class Meeting
    {
        public DateTime Start { get; set; }

        public MeetingClass Class { get; set; }

        public List<MeetingParticipant> Participants { get; set; }


        public Meeting Clone()
        {
            return new Meeting
            {
                Start = Start,
                Class = Class,

            };
        }
    }
}
