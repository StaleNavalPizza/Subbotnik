using System;
using System.Collections.Generic;

namespace Subbotnik.Model
{
    public class Meeting
    {
        public int Id { get; set; }

        public DateTime Start { get; set; }

        public MeetingClass Class { get; set; }

        public List<MeetingParticipant> Participants { get; set; }

        public Meeting()
        { }


        public Meeting Clone()
        {
            return new Meeting
            {
                Id = Id,
                Start = Start,
                Class = Class,

                // TODO: copy Participants
            };
        }
    }
}
