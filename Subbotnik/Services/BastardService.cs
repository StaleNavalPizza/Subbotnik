using System;
using System.Collections.Generic;

using NLog;
using Subbotnik.Model;
using Subbotnik.Repository;
using Subbotnik.Setup;

namespace Subbotnik.Services
{
    public class BastardService
    {
        private static readonly ILogger _logger = LogManager.GetLogger(nameof(BastardService));


        public IEnumerable<Bastard> GetBastards()
        {
            _logger.Debug("{0}", nameof(GetBastards));
            try
            {
                var repo = RepositorySetup.Repo.Bastards;
                var list = repo.Get();
                return list;
            }
            catch (Exception exc)
            {
                _logger.Error(exc, "{0} failed", nameof(GetBastards));
                return null;
            }
        }
    }
}
