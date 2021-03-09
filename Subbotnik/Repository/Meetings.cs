using System;
using System.Collections.Generic;
using System.Linq;

using Subbotnik.Model;

namespace Subbotnik.Repository
{
    public static class Meetings
    {
        private static readonly List<Meeting> _meetings;

        static Meetings()
        {
            var bastards = Bastards.GetAllMen();

            var meet1 = new Meeting
            {
                Class = MeetingClass.House,
                Start = new DateTime(2021, 2, 23),
                //Participants = bastards.Select(bs => new MeetingParticipant{ .ToList(),
            };
            var partips = bastards.Select(bs => new MeetingParticipant
            {
                //Event = meet1,
                Participant = bs,
            }).ToList();
            meet1.Participants = partips;

            _meetings = new List<Meeting>
            {
                meet1,
            };
        }

        public static List<Meeting> GetAllMeetings()
        {
            // TODO: clone instances
            return _meetings;
        }
    }
}
