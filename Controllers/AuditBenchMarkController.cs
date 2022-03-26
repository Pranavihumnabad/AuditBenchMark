using AuditBenchMark.Models;
using AuditBenchMark.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuditBenchMark.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditBenchMarkController : ControllerBase
    {
        private readonly IAuditBenchmarkService _service;
        public AuditBenchMarkController(IAuditBenchmarkService service)
        {
            _service = service;
        }
        // GET: api/<AuditBenchMarkController>
        [HttpGet]
        public ActionResult<List<BenchmarkResponseAuditType>> Get()
        {
            List<BenchmarkResponseAuditType> res = _service.GetAuditBenchmarks();
            return Ok(res);
        }
        [Route("getAuditTypeMaster")]
        [HttpGet]
        public ActionResult<List<AuditTypeMaster>> GetAuditMaster()
        {
            return Ok(_service.GetAuditMaster());
        }

        // GET api/<AuditBenchMarkController>/5

    }
}
