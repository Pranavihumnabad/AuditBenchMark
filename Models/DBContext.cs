using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchMark.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options) { 
        }

        public DbSet<BenchmarkResponseAuditType> BenchmarkResponseAuditTypes { get; set; }
        public DbSet<AuditTypeMaster> AuditTypeMasters { get; set; }
    }
}

