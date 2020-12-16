using Facturations.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturations.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : Controller
    {
        private readonly ILogger<FacturesController> _logger;
        private readonly IBusinessData _data;

        public DashboardController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public Dictionary<string, string> Get()
        {
            return new Dictionary<string, string>() {
                { "Montants réglés", _data.SalesRevenue.ToString() },
                { "Montants dûs" , _data.Outstanding.ToString() } 
                };
        }       
    }
}
