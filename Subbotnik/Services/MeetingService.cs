using System;
using System.Collections.Generic;

using NLog;
using Subbotnik.Model;
using Subbotnik.Repository;

namespace Subbotnik.Services
{
    public class MeetingService
    {
        private static readonly ILogger _logger = LogManager.GetLogger(nameof(MeetingService));


        public List<Meeting> GetMeetings()
        {
            _logger.Debug("{0}", nameof(GetMeetings));
            try
            {
                var list = Meetings.GetAllMeetings();
                return list;
            }
            catch (Exception exc)
            {
                _logger.Error(exc, "{0} failed", nameof(GetMeetings));
                return null;
            }
        }
    }
}
