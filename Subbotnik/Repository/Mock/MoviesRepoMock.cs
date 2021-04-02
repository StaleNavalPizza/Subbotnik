using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

using Subbotnik.Model;

namespace Subbotnik.Repository.Mock
{
    internal class MoviesRepoMock : IMoviesRepo
    {
        private readonly ConcurrentBag<Movie> _movies;

        public MoviesRepoMock()
        {
            _movies = new ConcurrentBag<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "In-facto",
                    Validated = false,
                },
            };
        }

        public IEnumerable<Movie> Get()
        {
            var safeList = _movies.Select(mov => mov.Clone()).ToList();
            return safeList;
        }

        public Movie Get(int key)
        {
            // TODO: make the proper, effective, async search-by-key, using the IQueryable
            var movie = _movies.FirstOrDefault(mov => mov.Id == key);
            return movie?.Clone();
        }
    }
}
