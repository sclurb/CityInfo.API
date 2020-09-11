using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [ApiController]
    [Route("api/testDatabase")]
    public class DummyController : Controller
    {
        private readonly CityInfoContext _ctx;

        public DummyController(CityInfoContext ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }
        [HttpGet]
        public IActionResult TestDaatabase()
        {
            return Ok();
        }
    }
}
