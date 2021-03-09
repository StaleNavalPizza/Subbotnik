using System;
using System.Collections.Generic;

using Subbotnik.Model;

namespace Subbotnik.Dto
{
    //public class 
    public class MovieRecommendationDto
    {
        public string MovieTitle { get; set; }

        public Bastard Recommender { get; set; }
    }
}
