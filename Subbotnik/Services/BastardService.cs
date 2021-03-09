using System;
using System.Collections.Generic;

using NLog;
using Subbotnik.Model;
using Subbotnik.Repository;

namespace Subbotnik.Services
{
    public class BastardService
    {
        private static readonly ILogger _logger = LogManager.GetLogger(nameof(BastardService));


        public List<Bastard> GetBastards()
        {
            _logger.Debug("{0}", nameof(GetBastards));
            try
            {
                var list = Bastards.GetAllMen();
                return list;
            }
            catch (Exception exc)
            {
                _logger.Error(exc, "{0} failed", nameof(GetBastards));
                return null;
            }
        }

        //public void AddMovie(Movie newMovie)
        //{
        //    _logger.Debug("{0}", nameof(newMovie));
        //    try
        //    {
        //        Movies.AddMovie(newMovie);
        //    }
        //    catch (Exception exc)
        //    {
        //        _logger.Error(exc, "{0} failed", nameof(newMovie));
        //    }
        //}
    }
}
