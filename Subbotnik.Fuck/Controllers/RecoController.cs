using Microsoft.AspNetCore.Mvc;
using Subbotnik.Services;

namespace Subbotnik.Fuck.Movies
{
    [Route("api/[controller]")]
    public class RecoController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            var service = new RecoService();
            var list = service.GetRecommendations();
            var result = new JsonResult(list);
            return result;
        }
    }
}