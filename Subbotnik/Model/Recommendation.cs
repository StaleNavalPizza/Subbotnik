using System.Collections.Generic;

namespace Subbotnik.Model
{
    public class Recommendation
    {
        public int Id { get; set; }

        public Bastard Recommender { get; set; }

        public Movie Movie { get; set; }

        public Meeting FirstMeeting { get; set; }

        public List<InterestPoint> Points { get; set; }
    }
}
