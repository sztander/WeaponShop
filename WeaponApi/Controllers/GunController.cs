using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WeaponApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GunController : ControllerBase
    {
        private readonly ILogger<GunController> _logger;

        public GunController(ILogger<GunController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Gun> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Gun
            {
                Name = "test"
            })
            .ToArray();
        }
    }
}
