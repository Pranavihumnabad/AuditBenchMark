using AuditBenchMark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchMark.Services
{
    public interface IAuditBenchmarkService
    {
        public List<BenchmarkResponseAuditType> GetAuditBenchmarks();
        public List<AuditTypeMaster> GetAuditMaster();


    }
}
