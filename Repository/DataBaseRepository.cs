using AuditBenchMark.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchMark.Repository
{
    public class DataBaseRepository : IDataBaseRepository
    {
        private readonly DBContext _context;
        public DataBaseRepository(DBContext context)
        {
            _context = context;
        }
        public List<BenchmarkResponseAuditType> GetAllData()
        {
            List<BenchmarkResponseAuditType> list = _context.BenchmarkResponseAuditTypes.ToList();
           // return new List<AuditBenchmark>();
             return list;
        }
        public List<AuditTypeMaster> GetAuditMaster()
        {
            List<AuditTypeMaster> list = _context.AuditTypeMasters.ToList();
            return list;
        }


    }
}
