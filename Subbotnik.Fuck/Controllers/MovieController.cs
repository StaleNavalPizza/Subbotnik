using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Subbotnik.Model;
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

    //[Controller]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        [HttpGet]
        //public Task<ActionResult<IEnumerable<Movie>>> Get()
        public ActionResult Get()
        {
            var service = new MovieService();
            var list = service.GetMovies();
            var result = new JsonResult(list);
            return result;
        }
    }
}