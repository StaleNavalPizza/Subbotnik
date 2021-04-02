using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

using Subbotnik.Model;

namespace Subbotnik.Repository.Mock
{
    internal class RecommendationsRepoMock : IRecommendationsRepo
    {
        private readonly ConcurrentBag<Recommendation> _recos;

        public RecommendationsRepoMock(IEnumerable<Bastard> bastards, IEnumerable<Meeting> meets, IEnumerable<Movie> movies)
        {
            _recos = new ConcurrentBag<Recommendation>
            {
                new Recommendation
                {
                    Id = 1,
                    Movie = movies.First(),
                    Recommender = bastards.FirstOrDefault(bs => bs.Name == "Wowa"), // ?? bastards[0],
                    Points = new List<InterestPoint> { InterestPoint.Philosophy },
                    FirstMeeting = meets.First(),
                },
            };
        }

        public Recommendation Get(int key)
        {
            // TODO: make the proper, effective, async search-by-key, using the IQueryable
            var reco = _recos.FirstOrDefault(rc => rc.Id == key);
            return reco; //?.Clone();
        }

        public IEnumerable<Recommendation> Get()
        {
            var safeList = _recos.Select(rc => rc).ToList(); //rc.Clone()
            return safeList;
        }
    }
}
