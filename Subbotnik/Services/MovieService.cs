using System;
using System.Collections.Generic;
using System.Text;

using NLog;
using Subbotnik.Model;
using Subbotnik.Repository;

namespace Subbotnik.Services
{


    public class MovieService
    {
        private static readonly ILogger _logger = LogManager.GetLogger(nameof(MovieService));


        public List<Movie> GetMovies()
        {
            _logger.Debug("{0}", nameof(GetMovies));
            try
            {
                var list = Movies.GetAllMovies();
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
                Movies.AddMovie(newMovie);
            }
            catch (Exception exc)
            {
                _logger.Error(exc, "{0} failed", nameof(newMovie));
            }
        }
    }

    public class RecoService
    {
        private static readonly ILogger _logger = LogManager.GetLogger(nameof(RecoService));

        public List<Recommendation> GetRecommendations()
        {
            _logger.Debug("{0}", nameof(GetRecommendations));
            try
            {
                var list = Recommendations.GetAllRecommendations();
                return list;
            }
            catch (Exception exc)
            {
                _logger.Error(exc, "{0} failed", nameof(GetRecommendations));
                return null;
            }
        }
    }
}
