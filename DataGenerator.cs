using AuditBenchMark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchMark
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DBContext(
            serviceProvider.GetRequiredService<DbContextOptions<DBContext>>()))
            {
                if (context.BenchmarkResponseAuditTypes.Any())
                {
                    return;
                }
                if (context.AuditTypeMasters.Any())
                {
                    return;
                }
                context.AuditTypeMasters.AddRange(
                    new AuditTypeMaster
                    {
                        AuditType = "Internal",
                        AuditTypeId = 1
                    },
                    new AuditTypeMaster
                    {
                        AuditType = "SOX",
                        AuditTypeId = 2
                    }

                    );
                context.BenchmarkResponseAuditTypes.AddRange(
                 new BenchmarkResponseAuditType
                 {
                     Id=1,
                     AuditTypeId = 1,
                     AuditResultStatus = "Green",
                     MinAcceptableValue = 0,
                     MaxAcceptableValue = 3,
                     RemedialAction = "No Action Needed"
                 },
                 new BenchmarkResponseAuditType
                 {
                     Id = 2,

                     AuditTypeId = 1,
                     AuditResultStatus = "Red",
                     MinAcceptableValue = 4,
                     MaxAcceptableValue = 1000,
                     RemedialAction = "Action to be taken in 2 weeks"
                 },
                 new BenchmarkResponseAuditType
                 {
                     Id = 3,

                     AuditTypeId = 2,
                     AuditResultStatus = "Green",
                     MinAcceptableValue = 0,
                     MaxAcceptableValue = 1,
                     RemedialAction = "No Action Needed"
                 },
                 new BenchmarkResponseAuditType
                 {
                     Id = 4,

                     AuditTypeId = 2,
                     AuditResultStatus = "Red",
                     MinAcceptableValue = 2,
                     MaxAcceptableValue = 1000,
                     RemedialAction = "Action to be taken in 1 week"
                 }




                ) ;  



                context.SaveChanges();
            }
        }
    }
}
