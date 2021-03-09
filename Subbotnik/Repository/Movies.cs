using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

using Subbotnik.Model;

namespace Subbotnik.Repository
{

    public static class Movies
    {
        private static readonly ConcurrentBag<Movie> _movies;

        static Movies()
        {
            //_movies = new List<Movie>
            //{
            //    new Movie
            //    {
            //        Title = "In-facto",
            //        Validated = false,
            //    },
            //};
            _movies = new ConcurrentBag<Movie>(MovieDraftRepo.Movies);
        }


        public static List<Movie> GetAllMovies()
        {
            var safeList = _movies.Select(org => org.Clone()).ToList();
            return safeList;
        }

        public static void AddMovie(Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }

            _movies.Add(movie);
        }
    }
}
