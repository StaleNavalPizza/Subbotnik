using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

using Subbotnik.Model;

namespace Subbotnik.Repository
{
    public static class Recommendations
    {
        private static readonly ConcurrentBag<Recommendation> _recos;

        static Recommendations()
        {
            var bastards = Bastards.GetAllMen();
            var meets = Meetings.GetAllMeetings();

            _recos = new ConcurrentBag<Recommendation>
            {
                new Recommendation
                {
                    Movie = MovieDraftRepo.Movies[0],
                    Recommender = bastards.FirstOrDefault(bs => bs.Name == "Wowa"), // ?? bastards[0],
                    Points = new List<InterestPoint> { InterestPoint.Philosophy },
                    FirstMeeting = meets[0],
                },
            };
        }

        public static List<Recommendation> GetAllRecommendations()
        {
            return _recos.ToList();
        }
    }
}
