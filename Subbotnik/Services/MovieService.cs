using System;
using System.Collections.Generic;
using System.Text;

using NLog;
using Subbotnik.Model;
using Subbotnik.Repository;
using Subbotnik.Setup;

namespace Subbotnik.Services
{
    public class MovieService
    {
        private static readonly ILogger _logger = LogManager.GetLogger(nameof(MovieService));


        public IEnumerable<Movie> GetMovies()
        {
            _logger.Debug("{0}", nameof(GetMovies));
            try
            {
                var repo = RepositorySetup.Repo.Movies;
                var list = repo.Get();
                return list;
            }
            catch (Exception exc)
            {
                _logger.Error(exc, "{0} failed", nameof(GetMovies));
                return null;
            }
        }

        public void AddMovie(Movie newMovie)
        {
            _logger.Debug("{0}", nameof(newMovie));
            try
            {
                //MoviesRepoMock.AddMovie(newMovie);
            }
            catch (Exception exc)
            {
                _logger.Error(exc, "{0} failed", nameof(newMovie));
            }
        }
    }
}
