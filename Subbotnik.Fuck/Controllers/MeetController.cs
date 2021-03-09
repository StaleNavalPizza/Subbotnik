using Microsoft.AspNetCore.Mvc;
using Subbotnik.Services;

namespace Subbotnik.Fuck.Movies
{
    [Route("api/[controller]")]
    public class MeetController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            var service = new MeetingService();
            var list = service.GetMeetings();
            var result = new JsonResult(list);
            return result;
        }
    }
}