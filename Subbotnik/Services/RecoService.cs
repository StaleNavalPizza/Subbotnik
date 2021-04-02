using System;
using System.Collections.Generic;

using NLog;
using Subbotnik.Model;
using Subbotnik.Repository;
using Subbotnik.Setup;

namespace Subbotnik.Services
{
    public class RecoService
    {
        private static readonly ILogger _logger = LogManager.GetLogger(nameof(RecoService));

        public IEnumerable<Recommendation> GetRecommendations()
        {
            _logger.Debug("{0}", nameof(GetRecommendations));
            try
            {
                var repo = RepositorySetup.Repo.Recommendations;
                var list = repo.Get();
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
