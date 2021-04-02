using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

using Subbotnik.Model;

namespace Subbotnik.Repository.Mock
{
    internal class MeetingsRepoMock : IMeetingsRepo
    {
        private readonly ConcurrentBag<Meeting> _meetings;

        public MeetingsRepoMock(IEnumerable<Bastard> bastards)
        {
            var meet1 = new Meeting
            {
                Id = 1,
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

            _meetings = new ConcurrentBag<Meeting>
            {
                meet1,
            };
        }

        public Meeting Get(int key)
        {
            //IQueryable<Bastard> men;
            //men.FirstOrDefault ...

            // TODO: make the proper, effective, async search-by-key, using the IQueryable
            var man = _meetings.FirstOrDefault(mt => mt.Id == key);
            return man?.Clone();
        }

        public IEnumerable<Meeting> Get()
        {
            var safeList = _meetings.Select(mt => mt.Clone()).ToList();
            return safeList;
        }
    }
}
