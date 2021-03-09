using Microsoft.AspNetCore.Mvc;
using Subbotnik.Services;

namespace Subbotnik.Fuck.Movies
{
    [Route("api/[controller]")]
    public class BastardController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            var service = new BastardService();
            var list = service.GetBastards();
            var result = new JsonResult(list);
            return result;
        }
    }
}