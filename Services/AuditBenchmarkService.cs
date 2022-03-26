using AuditBenchMark.Models;
using AuditBenchMark.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchMark.Services
{
    public class AuditBenchmarkService : IAuditBenchmarkService
    {
        private readonly IDataBaseRepository _db;
        public AuditBenchmarkService(IDataBaseRepository db)
        {
            _db = db;
        }
        public List<BenchmarkResponseAuditType> GetAuditBenchmarks()
        {
            List<BenchmarkResponseAuditType> list = _db.GetAllData();
            if(list.Count == 0)
                throw new Exception("Can not find data");
            return list;
        }
        public List<AuditTypeMaster> GetAuditMaster()
        {
            return _db.GetAuditMaster();
        }

    }
}
