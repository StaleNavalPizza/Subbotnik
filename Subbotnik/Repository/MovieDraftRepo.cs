using System.Collections.Generic;

using Subbotnik.Model;

namespace Subbotnik.Repository
{
    internal static class MovieDraftRepo
    {
        public static readonly IReadOnlyList<Movie> Movies;

        static MovieDraftRepo()
        {
            Movies = new List<Movie>
            {
                new Movie
                {
                    Title = "In-facto",
                    Validated = false,
                },
            };
        }
    }
}
