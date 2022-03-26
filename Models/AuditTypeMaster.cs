using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchMark.Models
{
    public class AuditTypeMaster
    {
        [Key]
        public int AuditTypeId { get; set; }

        public string AuditType { get; set; }
    }
}
