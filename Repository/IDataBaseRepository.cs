using AuditBenchMark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchMark.Repository
{
    public interface IDataBaseRepository
    {
        public List<BenchmarkResponseAuditType> GetAllData();
        public List<AuditTypeMaster> GetAuditMaster();


    }
}
